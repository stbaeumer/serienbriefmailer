using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public partial class frmSerienbriefFelder : Form
    {
        public frmSerienbriefFelder()
        {
            InitializeComponent();
        }

        private void frmSerienbriefFelder_Load(object sender, EventArgs e)
        {
        
            // Die ComboBox wird mit der Objektliste verbunden.

            BindingSource bs1 = new BindingSource();
            bs1.DataSource = Global.nral;
            cbxRegExName.DataSource = Global.nral;

            cbxRegExName.DisplayMember = "NameRegEx";
            cbxRegExName.ValueMember = "DefinitionRegEx";
            cbxRegExName.ValueMember = "BeschreibungRegEx";
            cbxRegExName.ValueMember = "Begrenzer1";
            cbxRegExName.ValueMember = "Begrenzer2";

            ReguläreAusdrücke.SerializeToXml(Global.nral, "jimbi3.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxRegExName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            tbxRegExDefinition.Enabled = true;
            tbxRegExBeschreibung.Enabled = true;
            tbxRegExBeschreibung.Text = "";
            tbxRegExDefinition.Text = "";
            cbxRegExName.Text = "";
            tbxBegrenzer1.Text = "";
            tbxBegrenzer2.Text = "";
        }

        private void btnRegExSpeichern_Click(object sender, EventArgs e)
        {
            if (cbxRegExName.SelectedIndex == 0)
            {
                Properties.Settings.Default.RegExBeschreibung1 = tbxRegExBeschreibung.Text;
                Properties.Settings.Default.RegExDefinition1 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 1)
            {
                Properties.Settings.Default.RegExBeschreibung2 = tbxRegExBeschreibung.Text;
                Properties.Settings.Default.RegExDefinition2 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 2)
            {
                Properties.Settings.Default.RegExBeschreibung3 = tbxRegExBeschreibung.Text;
                Properties.Settings.Default.RegExDefinition3 = tbxRegExDefinition.Text;
            } 
            if (cbxRegExName.SelectedIndex == 3)
            {
                Properties.Settings.Default.RegExBeschreibung4 = tbxRegExBeschreibung.Text;
                Properties.Settings.Default.RegExDefinition4 = tbxRegExDefinition.Text;
            } 
            if (cbxRegExName.SelectedIndex == 4)
            {
                Properties.Settings.Default.RegExBeschreibung5 = tbxRegExBeschreibung.Text;
                Properties.Settings.Default.RegExDefinition5 = tbxRegExDefinition.Text;
            } 
            if (cbxRegExName.SelectedIndex == 5)
            {
                Properties.Settings.Default.RegExBeschreibung6 = tbxRegExBeschreibung.Text;
                Properties.Settings.Default.RegExDefinition6 = tbxRegExDefinition.Text;
            }
            Properties.Settings.Default.Save();
        }

        private void cbxRegExName_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbxRegExDefinition.Text = Global.nral[cbxRegExName.SelectedIndex].DefinitionRegEx.ToString();
            tbxRegExBeschreibung.Text = Global.nral[cbxRegExName.SelectedIndex].BeschreibungRegEx.ToString();
            tbxBegrenzer1.Text = Global.nral[cbxRegExName.SelectedIndex].Begrenzer1.ToString();
            tbxBegrenzer2.Text = Global.nral[cbxRegExName.SelectedIndex].Begrenzer2.ToString();
        }

        private void btnRegExExportieren_Click(object sender, EventArgs e)
        {
            ReguläreAusdrücke.SerializeToXml(Global.fnral, "jimbi4.xml");
        }

        private void btnRegExFeldImportieren_Click(object sender, EventArgs e)
        {
            string pfad = @"C:\Users\bm\Documents\Visual Studio 2012\Projects\Coelina\Coelina\bin\Debug\jimbi4.xml";

            // Get file content into string.

            string feil = File.ReadAllText(pfad);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://coelina.de");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            try
            {
            PdfReader pdfReader = new PdfReader(Properties.Settings.Default.neuesteDatei);

            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            string derGesamteAusgeleseneTextInEinemString = PdfTextExtractor.GetTextFromPage(pdfReader, 1, strategy);

            derGesamteAusgeleseneTextInEinemString = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(derGesamteAusgeleseneTextInEinemString)));
            
                if (tbxBegrenzer1.Text != "")
            {
                // Überflüssiges vorne abschneiden

                Regex regex = new Regex(tbxBegrenzer1.Text);

                string[] substrings = regex.Split(derGesamteAusgeleseneTextInEinemString);

                derGesamteAusgeleseneTextInEinemString = substrings[1];
            }


            if (tbxBegrenzer2.Text != "")
            {
                // Überflüssiges hinten abschneiden

                Regex hinten = new Regex(tbxBegrenzer2.Text);

                string[] substrings = hinten.Split(derGesamteAusgeleseneTextInEinemString);

                derGesamteAusgeleseneTextInEinemString = substrings[0];
            }
            
             
            

            text.Append(derGesamteAusgeleseneTextInEinemString);

            pdfReader.Close();
         
            MessageBox.Show("Das ist der gesamte ausgelesene Text der ersten Seite:\n\n" + derGesamteAusgeleseneTextInEinemString, "Coelina");

            string filtrat = "";

            int i = 0;

            while (true)
            {
                try
                {
                    filtrat = filtrat + "\n" + frmSerienbriefdateiWählen.NeuePdfDatei.ReadPdfFile(Properties.Settings.Default.neuesteDatei, Global.nral[cbxRegExName.SelectedIndex].DefinitionRegEx, Global.nral[cbxRegExName.SelectedIndex].Begrenzer1, Global.nral[cbxRegExName.SelectedIndex].Begrenzer2, cbxRegExName.SelectedIndex)[i];
                    i++;
                }
                catch
                {
                    MessageBox.Show("Aus dem ausgelsenen Text konnte das gefiltert werden:\n" + filtrat, "Coelina");
                    break;
                }
            }
                      

            //derGesamteAusgeleseneTextInEinemString = derGesamteAusgeleseneTextInEinemString.Substring(derGesamteAusgeleseneTextInEinemString.IndexOf(':') + 1);

            //MessageBox.Show(derGesamteAusgeleseneTextInEinemString, "Das ist der gesamte gefundene und dann gefilterte Text:");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie müssen eine PDF-Datei auswählen.\n\n" +ex, "Coelina");
            }

        }

        private void tbxRegExBeschreibung_TextChanged(object sender, EventArgs e)
        {
            Global.fnral[cbxRegExName.SelectedIndex].BeschreibungRegEx = tbxRegExBeschreibung.Text;
            if (cbxRegExName.SelectedIndex == 0)
            {
                Properties.Settings.Default.RegExBeschreibung1 = tbxRegExBeschreibung.Text;    
            }
            if (cbxRegExName.SelectedIndex == 1)
            {
                Properties.Settings.Default.RegExBeschreibung2 = tbxRegExBeschreibung.Text;
            }
            if (cbxRegExName.SelectedIndex == 2)
            {
                Properties.Settings.Default.RegExBeschreibung3 = tbxRegExBeschreibung.Text;
            }
            if (cbxRegExName.SelectedIndex == 3)
            {
                Properties.Settings.Default.RegExBeschreibung4 = tbxRegExBeschreibung.Text;
            }
            if (cbxRegExName.SelectedIndex == 4)
            {
                Properties.Settings.Default.RegExBeschreibung5 = tbxRegExBeschreibung.Text;
            }
            if (cbxRegExName.SelectedIndex == 5)
            {
                Properties.Settings.Default.RegExBeschreibung6 = tbxRegExBeschreibung.Text;
            }
            Properties.Settings.Default.Save();
        }

        private void tbxRegExDefinition_TextChanged(object sender, EventArgs e)
        {
            Global.fnral[cbxRegExName.SelectedIndex].DefinitionRegEx = tbxRegExDefinition.Text;
            if (cbxRegExName.SelectedIndex == 0)
            {
                Properties.Settings.Default.RegExDefinition1 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 1)
            {
                Properties.Settings.Default.RegExDefinition2 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 2)
            {
                Properties.Settings.Default.RegExDefinition3 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 3)
            {
                Properties.Settings.Default.RegExDefinition4 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 4)
            {
                Properties.Settings.Default.RegExDefinition5 = tbxRegExDefinition.Text;
            }
            if (cbxRegExName.SelectedIndex == 5)
            {
                Properties.Settings.Default.RegExDefinition6 = tbxRegExDefinition.Text;
            }
            Properties.Settings.Default.Save();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Global.InitNral();
        }

        private void tbxBegrenzer1_TextChanged(object sender, EventArgs e)
        {
            Global.fnral[cbxRegExName.SelectedIndex].Begrenzer1 = tbxBegrenzer1.Text;
            if (cbxRegExName.SelectedIndex == 0)
            {
                Properties.Settings.Default.RegExBegrenzer1_1 = tbxBegrenzer1.Text;
            }
            if (cbxRegExName.SelectedIndex == 1)
            {
                Properties.Settings.Default.RegExBegrenzer1_2 = tbxBegrenzer1.Text;
            }
            if (cbxRegExName.SelectedIndex == 2)
            {
                Properties.Settings.Default.RegExBegrenzer1_3 = tbxBegrenzer1.Text;
            }
            if (cbxRegExName.SelectedIndex == 3)
            {
                Properties.Settings.Default.RegExBegrenzer1_4 = tbxBegrenzer1.Text;
            }
            if (cbxRegExName.SelectedIndex == 4)
            {
                Properties.Settings.Default.RegExBegrenzer1_5 = tbxBegrenzer1.Text;
            }
            if (cbxRegExName.SelectedIndex == 5)
            {
                Properties.Settings.Default.RegExBegrenzer1_6 = tbxBegrenzer1.Text;
            }
            Properties.Settings.Default.Save();
        }

        private void tbxBegrenzer2_TextChanged(object sender, EventArgs e)
        {
            Global.fnral[cbxRegExName.SelectedIndex].Begrenzer2 = tbxBegrenzer2.Text;
            if (cbxRegExName.SelectedIndex == 0)
            {
                Properties.Settings.Default.RegExBegrenzer2_1 = tbxBegrenzer2.Text;
            }
            if (cbxRegExName.SelectedIndex == 1)
            {
                Properties.Settings.Default.RegExBegrenzer2_2 = tbxBegrenzer2.Text;
            }
            if (cbxRegExName.SelectedIndex == 2)
            {
                Properties.Settings.Default.RegExBegrenzer2_3 = tbxBegrenzer2.Text;
            }
            if (cbxRegExName.SelectedIndex == 3)
            {
                Properties.Settings.Default.RegExBegrenzer2_4 = tbxBegrenzer2.Text;
            }
            if (cbxRegExName.SelectedIndex == 4)
            {
                Properties.Settings.Default.RegExBegrenzer2_5 = tbxBegrenzer2.Text;
            }
            if (cbxRegExName.SelectedIndex == 5)
            {
                Properties.Settings.Default.RegExBegrenzer2_6 = tbxBegrenzer2.Text;
            }
            Properties.Settings.Default.Save();
        }        
    }
}
