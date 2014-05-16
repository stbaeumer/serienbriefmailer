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
    public partial class frmVerteiler : Form
    {
        public frmVerteiler()
        {
            InitializeComponent();
        }

        

        private void frmVerteiler_Load(object sender, EventArgs e)
        {
            dgAlias.DataSource = Global.AliasMail;

            //todo: http://www.switchonthecode.com/tutorials/csharp-tutorial-binding-a-datagridview-to-a-collection
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://coelina.de");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Der Dialog zur Auswahl eines beliebigen Log-Verzeichnisses wird angeboten.

            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Wählen Sie ein Exportverzeichnis. \nDer Inhalt einer evtl. vorhandenen Datei wird überschrieben.";
            objDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Nur wenn in dem FolderBrowserDialog tatsächlich mit OK ein Pfad gewählt wurde, 
            // kommt es zum Export.

            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                // Export

                string exportverzeichnis = Path.Combine(objDialog.SelectedPath, "alias.csv");

                TextWriter tw = new StreamWriter(exportverzeichnis);

                for (int i = 0; i < Global.AliasMail.Count(); i++)
                {
                    tw.WriteLine("" + Global.AliasMail[i].Email + ", " + Global.AliasMail[i].Kürzel + ", " + Global.AliasMail[i].Name + ", " + Global.AliasMail[i].Alias1 + ", " + Global.AliasMail[i].Alias2 + ", " + Global.AliasMail[i].Alias3 + ", " + Global.AliasMail[i].Alias4 + "");
                }
                tw.Close();    
            }
        }

        private void btnCsvImportVerteiler_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV-Dateien (*.csv)|*.csv";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Title = "Wählen Sie eine CSV-Datei!";
            
            if (dialog.ShowDialog() == DialogResult.OK)
	        {
                this.dgAlias.DataSource = null;
                
                Global.AliasMail.Clear();

                Global.AliasMail = new AliasListe();

                string line = null;

                string alleAliasseInEinemString = "";

                TextReader readFile;

                readFile = new StreamReader(dialog.FileName);

                int zeilen = File.ReadLines(dialog.FileName).Count();

                while ((line = readFile.ReadLine()) != null)
                {
                    //MessageBox.Show(line);
                    string[] parts = line.Split(',');
                    Global.AliasMail.Add(new Alias(parts[0].TrimStart(' ').TrimEnd(' '), parts[1].TrimStart(' ').TrimEnd(' '), parts[2].TrimStart(' ').TrimEnd(' '), parts[3].TrimStart(' ').TrimEnd(' '), parts[4].TrimStart(' ').TrimEnd(' '), parts[5].TrimStart(' ').TrimEnd(' '), parts[6].TrimStart(' ').TrimEnd(' ')));
                    this.dgAlias.EndEdit();
                    alleAliasseInEinemString = alleAliasseInEinemString + line + ";";
                }


                //Regex.Replace(alleAliasseInEinemString, @", ", ",");
                //Regex.Replace(alleAliasseInEinemString, @" ,", ",");
                //alleAliasseInEinemString.Replace(" ,",",");
                MessageBox.Show(alleAliasseInEinemString.TrimEnd(';'));
                Properties.Settings.Default.AliasListe = alleAliasseInEinemString.TrimEnd(';');
                Properties.Settings.Default.Save();
                readFile.Close();
                readFile = null;
                dgAlias.DataSource = Global.AliasMail;
	        }
        }

        private void btnListeLöschen_Click(object sender, EventArgs e)
        {
            this.dgAlias.DataSource = null;
            Properties.Settings.Default.AliasListe = "";
            Properties.Settings.Default.Save();
            Global.AliasMail.Clear();
        }

        private void dgAlias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
