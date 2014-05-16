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
    public partial class frmAllgemeineEinstellungen : Form
    {
        public frmAllgemeineEinstellungen()
        {
            InitializeComponent();            
        }
        
        enum LogSpalten { Datum, Email, Kürzel, Name, Alias1, Alias2, Alias3, Alias4, leer };

        // Einige Mailprovider sind voreingestellt.

        MailProvider[] bekannteProvider;

        private void frmAllgemeineEinstellungen_Load(object sender, EventArgs e)
        {

            cbxInhaltDerLogdatei.Checked = Properties.Settings.Default.CCundBCCinLogDateiSchreiben;
            
            //MessageBox.Show(Properties.Settings.Default.LogSpaltenIndex1.ToString());
            
            //comboBoxSpalte1.DataSource = Enum.GetValues(typeof(LogSpalten));
            //comboBoxSpalte1.SelectedIndex = Properties.Settings.Default.LogSpaltenIndex1;

            //comboBoxSpalte2.DataSource = Enum.GetValues(typeof(LogSpalten));
            //comboBoxSpalte2.SelectedIndex = Properties.Settings.Default.LogSpaltenIndex2;

            //comboBoxSpalte3.DataSource = Enum.GetValues(typeof(LogSpalten));
            //comboBoxSpalte3.SelectedIndex = Properties.Settings.Default.LogSpaltenIndex3;

            //comboBoxSpalte4.DataSource = Enum.GetValues(typeof(LogSpalten));
            //comboBoxSpalte4.SelectedIndex = Properties.Settings.Default.LogSpaltenIndex4;

            //comboBoxSpalte5.DataSource = Enum.GetValues(typeof(LogSpalten));
            //comboBoxSpalte5.SelectedIndex = Properties.Settings.Default.LogSpaltenIndex5;

            //comboBoxSpalte6.DataSource = Enum.GetValues(typeof(LogSpalten));
            //comboBoxSpalte6.SelectedIndex = Properties.Settings.Default.LogSpaltenIndex6;

            bekannteProvider = new MailProvider[10];

            bekannteProvider[0] = new MailProvider("...", "...", 25, "...", false);
            bekannteProvider[1] = new MailProvider("Gmail über Port 25", "smtp.gmail.com", 25, "...@gmail.com", true);
            bekannteProvider[2] = new MailProvider("Gmail über Port 465", "smtp.gmail.com", 465, "...@gmail.com", true);
            bekannteProvider[3] = new MailProvider("Gmail über Port 587", "smtp.gmail.com", 587, "...@gmail.com", true);
            bekannteProvider[4] = new MailProvider("Web.de", "smtp.web.de", 25, "...@web.de", false);
            bekannteProvider[5] = new MailProvider("Yahoo", "smtp.mail.yahoo.com ", 465, "...@...", false);
            bekannteProvider[6] = new MailProvider("Hotmail", "smtp.live.com", 25, "...@...", false);
            bekannteProvider[7] = new MailProvider("Freenet", "mx.freenet.de", 587, "...@...", false);
            bekannteProvider[8] = new MailProvider("t-online", "smtpmail.t-online.de", 0, "...@...", false);
            bekannteProvider[9] = new MailProvider("AOL", "smtp.de.aol.com", 587, "...@...", false);


            cbxSmtpServer.Items.Add(bekannteProvider[0].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[1].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[2].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[3].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[4].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[5].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[6].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[7].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[8].Name);
            cbxSmtpServer.Items.Add(bekannteProvider[9].Name);

            
            cbxSmtpServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        
            // Die Textboxen werden mit den Werten aus den Settings gefüllt.
            
            tbxSmtpServer.Text = Properties.Settings.Default.smtpServer;
            tbxSmtpPort.Text = Properties.Settings.Default.smtpPort.ToString();
            tbxAbsender.Text = Properties.Settings.Default.absender;
            tbxPasswort.Text = Properties.Settings.Default.mailPassword;
            textBox1.Text = Properties.Settings.Default.DieseMailIgnorieren;
            textBox2.Text = Properties.Settings.Default.DieseDomainIgnorieren;
            tbxLogDatei.Text = Properties.Settings.Default.LogDatei;
            tbxBlindCopyAn.Text = Properties.Settings.Default.BlindCopyAn;

            checkBoxSslEinschalten.Checked = Properties.Settings.Default.SSLEinschalten;
            checkBox1.Checked = Properties.Settings.Default.NachVersandDateienLöschen;
            checkBoxAliasAktivieren.Checked = Properties.Settings.Default.AliasAktiv;
            cbkPasswortSpeichern.Checked = Properties.Settings.Default.PasswortSpeichern;
            cbxLogDateierweitern.Checked = Properties.Settings.Default.LogErweiternUndNichtLöschen;
            cbxSortierkriterium.Text = Properties.Settings.Default.SortierkriteriumLogdatei;

            if (tbxSmtpPort.Text.ToString() == "0")
            {
                tbxSmtpPort.BackColor = System.Drawing.Color.LightPink;
            }
            if (tbxSmtpServer.Text == "")
            {
                tbxSmtpServer.BackColor = System.Drawing.Color.LightPink;
            }
            if (tbxPasswort.Text == "")
            {
                tbxPasswort.BackColor = System.Drawing.Color.LightPink;
            }
            if (tbxAbsender.Text == "")
            {
                tbxAbsender.BackColor = System.Drawing.Color.LightPink;
            }
            
            
            if (File.Exists(Properties.Settings.Default.LogDatei))
            {
                // Wenn die Logdatei bereits existiert, wird sie in der tbx ausgewiesen.

                tbxLogDatei.Text = Properties.Settings.Default.LogDatei;
            }
            else
            {
                // Wenn die Logdatei noch nicht existiert bzw. der Pfad ungültig ist,
                // dann wird die in den eigenen Dateien angelegt.

                string eigeneDateien = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string coelinaLog = eigeneDateien + "\\coelina.log";
                File.CreateText(coelinaLog);
                Properties.Settings.Default.LogDatei = coelinaLog;
                Properties.Settings.Default.Save();
                tbxLogDatei.Text = coelinaLog;
            }
            checkBox2.Checked = Properties.Settings.Default.maillogSenden;
            checkBoxHtmlMail.Checked = Properties.Settings.Default.mailsAlsHtmlSenden;
            tbxLogKopf.Text = Properties.Settings.Default.kopfDerLogdatei;
            checkBox3.Checked = Properties.Settings.Default.BodyUndCoZurWiedervorlageSpeichern;

            //tbxDateiEndungDerLogDatei.Text = Properties.Settings.Default.LogdateiDateiendung;
            //tbxNameDerLogDatei.Text = Properties.Settings.Default.LogdateiName;
            
        }

        private void picMailLogDatei_Click(object sender, EventArgs e)
        {
            // Der Dialog zur Auswahl eines beliebigen Log-Verzeichnisses wird angeboten.

            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Wählen Sie ein Verzeichnis.";
            objDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            // Nur wenn in dem FolderBrowserDialog tatsächlich mit OK ein Pfad gewählt wurde, 
            // wird das bisherige Log-Verzeichnis überschrieben.

            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                tbxLogDatei.Text = objDialog.SelectedPath;
                string logDatei = Path.Combine(objDialog.SelectedPath,Properties.Settings.Default.LogdateiName+"."+Properties.Settings.Default.LogdateiDateiendung);
                Properties.Settings.Default.LogDatei = logDatei;
                Properties.Settings.Default.Save();

                // Wenn die Logdatei noch nicht existiert, wird sie erstellt.

                if (!File.Exists(logDatei))
                {
                    try
                    {
                        File.CreateText(logDatei);    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Im gewünschten Verzeichnis fehlt die Schreibberechtigung\n\n" + ex, "Coelina"); 
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.maillogSenden = checkBox2.Checked;
            Properties.Settings.Default.Save();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://coelina.de");
        }

        private void tbxLogDatei_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogDatei = tbxLogDatei.Text;
            Properties.Settings.Default.Save();
        }
                
        private void checkBoxHtmlMail_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mailsAlsHtmlSenden = checkBoxHtmlMail.Checked;
        }

        private void tbxLogKopf_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.kopfDerLogdatei = tbxLogKopf.Text;
            Properties.Settings.Default.Save();
        }

        private void cbxSmtpServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxSmtpServer.Text = bekannteProvider[cbxSmtpServer.SelectedIndex].SmtpServer;
            tbxSmtpPort.Text = bekannteProvider[cbxSmtpServer.SelectedIndex].SmtpPort.ToString();
            tbxAbsender.Text = bekannteProvider[cbxSmtpServer.SelectedIndex].User;
            checkBoxSslEinschalten.Checked = bekannteProvider[cbxSmtpServer.SelectedIndex].SslEinschalten;
            tbxPasswort.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string meldung = "";

            if (tbxSmtpServer.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(tbxSmtpServer.Text, @"\w+([-+.']\w+)*\.\w+([-.]\w+)*\.\w+([-.]\w+)*") == false)
            {
                tbxSmtpServer.BackColor = System.Drawing.Color.LightPink;
                Properties.Settings.Default.smtpServer = tbxSmtpServer.Text;
                Properties.Settings.Default.Save();
                meldung = meldung + "\nSMTP-Server nicht korrekt.";
            }
            else
            {
                tbxSmtpServer.BackColor = System.Drawing.Color.White;
                Properties.Settings.Default.smtpServer = tbxSmtpServer.Text;
                Properties.Settings.Default.Save();
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxSmtpPort.Text, @"[0-9]") == true)
            {
                tbxSmtpPort.BackColor = System.Drawing.Color.White;
                Properties.Settings.Default.smtpPort = Convert.ToInt32(tbxSmtpPort.Text);
            }
            else
            {
                tbxSmtpPort.BackColor = System.Drawing.Color.LightPink;
                meldung = meldung + "\nSMTP-Port nicht korrekt.";
            }

            if (tbxAbsender.Text == "" || tbxAbsender.Text.Contains('@') == false )
            {
                tbxAbsender.BackColor = System.Drawing.Color.LightPink;
                Properties.Settings.Default.absender = tbxAbsender.Text;
                meldung = meldung + "\nAbsender-E-Mail nicht korrekt.";
            }
            else
            {
                tbxAbsender.BackColor = System.Drawing.Color.White;
                Properties.Settings.Default.absender = tbxAbsender.Text;
            }

            if (tbxPasswort.Text == "")
            {
                tbxPasswort.BackColor = System.Drawing.Color.LightPink;
                meldung = meldung + "\nLeeres Passwort nicht zugelassen.";
                Properties.Settings.Default.mailPassword = tbxPasswort.Text;
            }
            else
            {
                tbxPasswort.BackColor = System.Drawing.Color.White;
                Properties.Settings.Default.mailPassword = tbxPasswort.Text;
            }

            Properties.Settings.Default.SSLEinschalten = checkBoxSslEinschalten.Checked;
            
            if (meldung == "")
            {
                Properties.Settings.Default.MaileinstellungenKorrekt = true;

                MessageBox.Show("SMTP-Server: " + Properties.Settings.Default.smtpServer + "\nSMTP-Port: " +
                Properties.Settings.Default.smtpPort + "\nAbsender-Adresse: " +
                Properties.Settings.Default.absender + "\nAbsender-Passwort: " +
                Properties.Settings.Default.mailPassword, "Coelina");

                try
                {
                    Nachricht testmail;
                    testmail = new Nachricht();
                    MailAddress m = new MailAddress("stbaeumer@gmail.com");
                    MessageBox.Show(testmail.testmailSenden("stbaeumer@gmail.com"), "Coelina");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: \n\nProbleme bei den Einstellungen. \nStimmen die E-Mail-Einstellungen?\n\nIst die Firewall richtig konfiguriert?\n\n " + ex, "Coelina");
                    Properties.Settings.Default.mailPassword = "";
                    Properties.Settings.Default.Save();
                    tbxPasswort.Text = "";
                }
            }
            else
            {
                MessageBox.Show(meldung, "Coelina");
                Properties.Settings.Default.MaileinstellungenKorrekt = false;
            }

            Properties.Settings.Default.Save();
        }

        //private void btnTestmailSenden_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Nachricht testmail;
        //        testmail = new Nachricht();
        //        MailAddress m = new MailAddress(tbxTestMailEmpfänger.Text);
        //        MessageBox.Show(testmail.testmailSenden(tbxTestMailEmpfänger.Text), "Coelina");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Fehler: \n\nDie E-Mail-Adresse scheint nicht gültig zu sein. \nStimmen die E-Mail-Einstellungen?\n\n" + ex,"Coelina");
        //    }
        //}

        private void tbxSmtpServer_TextChanged(object sender, EventArgs e)
        {
            // Validierung des SMTP-Servers. 

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxSmtpServer.Text, @"\w+([-+.']\w+)*\.\w+([-.]\w+)*\.\w+([-.]\w+)*") == true)
            {
                tbxSmtpServer.BackColor = System.Drawing.Color.White;
                //Properties.Settings.Default.smtpServer = tbxSmtpServer.Text;
                //Properties.Settings.Default.Save();
            }
            else
            {
                tbxSmtpServer.BackColor = System.Drawing.Color.LightPink;
                //Properties.Settings.Default.smtpServer = "";
                //Properties.Settings.Default.Save();
            }
        }

        private void tbxAbsender_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.absender = tbxAbsender.Text;
            //Properties.Settings.Default.Save();
        }

        private void tbxPasswort_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.mailPassword = tbxPasswort.Text;
            //Properties.Settings.Default.Save();
        }

        private void tbxSmtpPort_TextChanged(object sender, EventArgs e)
        {
            // Validierung der Portnummer.

            // Wenn die Portnummer aus Zahlen besteht oder die Zelle leer ist ...

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxSmtpPort.Text, @"[0-9]") == true || tbxSmtpPort.Text == "")
            {
                try
                {
                    tbxSmtpPort.BackColor = System.Drawing.Color.White;
                    //Properties.Settings.Default.smtpPort = Convert.ToInt32(tbxSmtpPort.Text);
                    //Properties.Settings.Default.Save();
                }
                catch
                {
                    tbxSmtpPort.BackColor = System.Drawing.Color.LightPink;
                    //Properties.Settings.Default.smtpPort = 0;
                    //Properties.Settings.Default.Save();
                }
            }
            else
            {
                tbxSmtpPort.BackColor = System.Drawing.Color.LightPink;
                //MessageBox.Show("Ungültiger SMTP-Port", "Coelina");
            }
        }

        private void checkBoxSslEinschalten_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BodyUndCoZurWiedervorlageSpeichern = checkBox3.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DieseMailIgnorieren = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DieseDomainIgnorieren = textBox2.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NachVersandDateienLöschen = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxAliasAktivieren_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AliasAktiv = checkBoxAliasAktivieren.Checked;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSpalte1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogSpaltenIndex1 = comboBoxSpalte1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSpalte2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogSpaltenIndex2 = comboBoxSpalte2.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSpalte3_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   Properties.Settings.Default.LogSpaltenIndex3 = comboBoxSpalte3.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSpalte4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogSpaltenIndex4 = comboBoxSpalte4.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSpalte5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogSpaltenIndex5 = comboBoxSpalte5.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBoxSpalte6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogSpaltenIndex6 = comboBoxSpalte6.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.Save();
        //}

        private void cbxInhaltDerLogdatei_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CCundBCCinLogDateiSchreiben = cbxInhaltDerLogdatei.Checked;
            Properties.Settings.Default.Save();
        }

        private void tbxNameDerLogDatei_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogdateiName = tbxNameDerLogDatei.Text;
            Properties.Settings.Default.Save();
        }

        private void tbxDateiEndungDerLogDatei_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.LogdateiDateiendung = tbxDateiEndungDerLogDatei.Text;
            Properties.Settings.Default.Save();
        }

        private void tbxBlindCopyAn_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BlindCopyAn = tbxBlindCopyAn.Text;
            Properties.Settings.Default.Save();
        }

        private void cbkPasswortSpeichern_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PasswortSpeichern = cbkPasswortSpeichern.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbxLogDateierweitern_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogErweiternUndNichtLöschen = cbxLogDateierweitern.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbxSortierkriterium_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SortierkriteriumLogdatei = cbxSortierkriterium.Text;
            Properties.Settings.Default.Save();
        }
    }
}
