using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public partial class frmVorschau : Form
    {
        public frmVorschau()
        {
            InitializeComponent();
        }

        private void frmVorschau_Load(object sender, EventArgs e)
        {
            if (Global.fNeueNachricht[0].Empfänger.Length < 4 || Global.fNeueNachricht[0] == null)
            {
                tbxEmpfänger.Text = "Es konnte kein Empfänger ermittelt werden.";
            }
            else
            {
                tbxEmpfänger.Text = Global.fNeueNachricht[0].Empfänger;
            }
                
            //tbxEmpfänger.Enabled = false;

            tbxCc.Text = Global.fNeueNachricht[0].cc;
            tbxBcc.Text = Global.fNeueNachricht[0].Bcc;
            tbxBetreff.Text = Global.fNeueNachricht[0].Betreff;
            tbxBody.Text = Global.fNeueNachricht[0].Body;
            tbxSrienbriefAnhang.Text = Global.fNeueNachricht[0].Dateianhang;
            tbxAnhang1.Text = Global.fNeueNachricht[0].OptionalerAnhang1;
            tbxAnhang2.Text = Global.fNeueNachricht[0].OptionalerAnhang2;
            tbxAnhang3.Text = Global.fNeueNachricht[0].OptionalerAnhang3;
            
            // Die Hscrollbar wird aktiviert und die Breite festgelegt

            int z = Global.fNeueNachricht.Count();
                    
            this.hScrollBar2.Maximum = z - 1;
        }

        // Jede einzelne Nachricht kann individuell verändert werden.

        protected void tbxCc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(tbxCc.Text);
                Global.fNeueNachricht[hScrollBar2.Value].cc = tbxCc.Text;
            }
            catch (Exception)
            {
                Global.fNeueNachricht[hScrollBar2.Value].cc = "";
            }
        }

        protected void tbxBcc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(tbxBcc.Text);
                Global.fNeueNachricht[hScrollBar2.Value].Bcc = tbxBcc.Text;
            }
            catch (Exception)
            {
                Global.fNeueNachricht[hScrollBar2.Value].Bcc = "";
            }
        }

        private bool IstEineAusführbareDatei(string path)
        {
            var twoBytes = new byte[2];
            try
            {
                using (var fileStream = File.Open(path, FileMode.Open))
                {
                    fileStream.Read(twoBytes, 0, 2);
                }
                if (Encoding.UTF8.GetString(twoBytes) == "MZ")
                {
                    MessageBox.Show("Es dürfen keine ausführbaren Dateien versandt werden.", "Coelina");
                }
                return Encoding.UTF8.GetString(twoBytes) == "MZ";
            }
            catch (Exception)
            {
                return Encoding.UTF8.GetString(twoBytes) != "MZ"; ;
            }
        }
               
        protected void tbxAnhang1_TextChanged(object sender, EventArgs e)
        {           
            if (File.Exists(Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1) || tbxAnhang1.Text == "")
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1 = tbxAnhang1.Text;                
            }
            else
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1 = "";
            }  
            if (IstEineAusführbareDatei(tbxAnhang1.Text) == true)
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1 = "";
                tbxAnhang1.Text = Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1;
            }                     
        }

        protected void tbxAnhang2_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2) || tbxAnhang2.Text == "")
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2 = tbxAnhang2.Text;                
            }
            else
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2 = "";
            }   
            if (IstEineAusführbareDatei(tbxAnhang2.Text) == true)
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2 = "";
                tbxAnhang2.Text = Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2;
            }                   
        }
        
        protected void tbxAnhang3_TextChanged(object sender, EventArgs e)
        {
             if (File.Exists(Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3) || tbxAnhang3.Text == "")
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3 = tbxAnhang3.Text;                
            }
             else
             {
                 Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3 = "";
             }
            if (IstEineAusführbareDatei(tbxAnhang3.Text) == true)
            {
                Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3 = "";
                tbxAnhang3.Text = Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3;
            }            
        }

        protected void tbxSrienbriefAnhang_TextChanged(object sender, EventArgs e)
        {
            Global.fNeueNachricht[hScrollBar2.Value].Dateianhang = tbxSrienbriefAnhang.Text;
        }

        protected void tbxBody_TextChanged(object sender, EventArgs e)
        {
            Global.fNeueNachricht[hScrollBar2.Value].Body = tbxBody.Text;
        }

        protected void tbxBetreff_TextChanged(object sender, EventArgs e)
        {
            Global.fNeueNachricht[hScrollBar2.Value].Betreff = tbxBetreff.Text;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (Global.fNeueNachricht[hScrollBar2.Value].Empfänger.Length < 4 || Global.fNeueNachricht[hScrollBar2.Value].Empfänger == "Diese Nachricht wurde von Ihnen gelöscht.")
            {
                tbxEmpfänger.Enabled = false;

                if (Global.fNeueNachricht[hScrollBar2.Value].Empfänger.Length < 4)
                {
                    tbxEmpfänger.Text = "Es konnte kein Empfänger ermittelt werden.";
                }
                if (Global.fNeueNachricht[hScrollBar2.Value].Empfänger == "Diese Nachricht wurde von Ihnen gelöscht.")
                {
                    tbxEmpfänger.Text = Global.fNeueNachricht[hScrollBar2.Value].Empfänger;
                }
                
                tbxCc.Enabled = false;
                tbxBcc.Enabled = false;
                tbxBetreff.Enabled = false;
                tbxBody.Enabled = false;
                tbxSrienbriefAnhang.Enabled = false;
                tbxAnhang1.Enabled = false;
                tbxAnhang2.Enabled = false;
                tbxAnhang3.Enabled = false;
            }
            else
            {
                tbxEmpfänger.Enabled = false;
                tbxEmpfänger.Text = Global.fNeueNachricht[hScrollBar2.Value].Empfänger;
                tbxCc.Enabled = true;
                tbxBcc.Enabled = true;
                tbxBetreff.Enabled = true;
                tbxBody.Enabled = true;
                tbxSrienbriefAnhang.Enabled = false;
                tbxAnhang1.Enabled = true;
                tbxAnhang2.Enabled = true;
                tbxAnhang3.Enabled = true;
            }
            tbxCc.Text = Global.fNeueNachricht[hScrollBar2.Value].cc;
            tbxBcc.Text = Global.fNeueNachricht[hScrollBar2.Value].Bcc;
            tbxBetreff.Text = Global.fNeueNachricht[hScrollBar2.Value].Betreff;
            tbxBody.Text = Global.fNeueNachricht[hScrollBar2.Value].Body;
            tbxSrienbriefAnhang.Text = Global.fNeueNachricht[hScrollBar2.Value].Dateianhang;
            tbxAnhang1.Text = Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1;
            tbxAnhang2.Text = Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2;
            tbxAnhang3.Text = Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3;
        }

        private void picAnhang1_Click(object sender, EventArgs e)
        {
            
        }

        private void picAnhang2_Click(object sender, EventArgs e)
        {
            
        }

        private void picAnhang3_Click(object sender, EventArgs e)
        {
            
        }

        public string wähleAnhang(string initialDirectory)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Alle Dateien (*.*)|*.*";
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Wählen Sie eine Datei!";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }

        private void picÖffneDateianhang_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            // Zuerst werden alle Textboxen in die Settings gespeichert.

            //todo: mach et Otze.

            frmLog frm = new frmLog();

            // frm2 soll innerhalb des MDI-Containers öffnen. Also wird der Parent des aktuellen Forms an das nächste Form übergeben.

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            
            
            
        }
        
        //private void button2_Click(object sender, EventArgs e)
        //{
            
        //    // Zuerst werden alle Textboxen in die Settings gespeichert.

        //    //todo: mach et Otze.

        //    frmSerienbriefEntwurfErzeugen frm = new frmSerienbriefEntwurfErzeugen();

        //    // frm2 soll innerhalb des MDI-Containers öffnen. Also wird der Parent des aktuellen Forms an das nächste Form übergeben.

        //    frm.MdiParent = this.MdiParent;
        //    frm.Show();
        //    this.Close();
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbxEmpfänger_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSrienbriefAnhang_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblBody_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Zuerst werden alle Textboxen in die Settings gespeichert.

            //todo: mach et Otze.

            frmSerienbriefdateiWählen frm = new frmSerienbriefdateiWählen();

            // frm2 soll innerhalb des MDI-Containers öffnen. Also wird der Parent des aktuellen Forms an das nächste Form übergeben.

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            // Zuerst werden alle Textboxen in die Settings gespeichert.

            //todo: mach et Otze.

            frmLog frm = new frmLog();

            // frm2 soll innerhalb des MDI-Containers öffnen. Also wird der Parent des aktuellen Forms an das nächste Form übergeben.

            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            tbxAnhang1.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1 = tbxAnhang1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tbxAnhang2.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2 = tbxAnhang2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxAnhang3.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3 = tbxAnhang3.Text;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Global.fNeueNachricht[hScrollBar2.Value].Dateianhang);
            }
            catch (Exception)
            {

                MessageBox.Show("Keine Berechtigung", "Coelina");
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://coelina.de");
        }

        private void btnDieseNachrichtLöschen_Click(object sender, EventArgs e)
        {
            Global.fNeueNachricht[hScrollBar2.Value].Empfänger = "Diese Nachricht wurde von Ihnen gelöscht.";
            tbxEmpfänger.Enabled = false;
            tbxEmpfänger.Text = Global.fNeueNachricht[hScrollBar2.Value].Empfänger;
            tbxCc.Enabled = false;
            tbxBcc.Enabled = false;
            tbxBetreff.Enabled = false;
            tbxBody.Enabled = false;
            tbxSrienbriefAnhang.Enabled = false;
            tbxAnhang1.Enabled = false;
            tbxAnhang2.Enabled = false;
            tbxAnhang3.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Global.fNeueNachricht[hScrollBar2.Value].Empfänger = "Diese Nachricht wurde von Ihnen gelöscht.";
            tbxEmpfänger.Enabled = false;
            tbxEmpfänger.Text = Global.fNeueNachricht[hScrollBar2.Value].Empfänger;
            tbxCc.Enabled = false;
            tbxBcc.Enabled = false;
            tbxBetreff.Enabled = false;
            tbxBody.Enabled = false;
            tbxSrienbriefAnhang.Enabled = false;
            tbxAnhang1.Enabled = false;
            tbxAnhang2.Enabled = false;
            tbxAnhang3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Global.fNeueNachricht[hScrollBar2.Value].Dateianhang);
            }
            catch (Exception)
            {

                MessageBox.Show("Keine Berechtigung", "Coelina");
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            tbxAnhang1.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang1 = tbxAnhang1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxAnhang2.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang2 = tbxAnhang2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tbxAnhang3.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Global.fNeueNachricht[hScrollBar2.Value].OptionalerAnhang3 = tbxAnhang3.Text;
        }
    }
}