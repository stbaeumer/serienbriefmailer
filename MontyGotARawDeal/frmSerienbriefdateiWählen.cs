using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public partial class frmSerienbriefdateiWählen : Form
    {
        public frmSerienbriefdateiWählen()
        {
            InitializeComponent();
        }

        // Das Objekt ist public static, damit es von anderen Formularen angesprochen werden kann.
        
        public static PdfDatei NeuePdfDatei = new PdfDatei();

        // Die Enum wird für Alias-Funktionalität benötigt.
 
        enum AliasKopfzeile { Email, Kürzel, Name, Alias1, Alias2, Alias3, Alias4 };

        private void frmSerienbriefdateiWählen_Load(object sender, EventArgs e)
        {
            checkBoxImmerNeuesteDateiVorschlagen.Checked = Properties.Settings.Default.immerNeuesteDateiVorschlagen;

            // Beim wiederholten Aufruf des Formulars innerhalb einer Session soll nicht erneut nach einer Datei gesucht werden.

            Global.fFormularZaehlerFormular1++;
            
            // Evtl. soll innerhalb einer Session die Logdatei nur erweitert werden.

            if (Properties.Settings.Default.LogErweiternUndNichtLöschen != true)
            {
                Global.fLogs.Clear();
            }
            
            if (Properties.Settings.Default.immerNeuesteDateiVorschlagen == true)
            {
                if (Directory.Exists(Properties.Settings.Default.aktivesVerzeichnis))
                {
                    NeuePdfDatei.AktivesVerzeichnis = Properties.Settings.Default.aktivesVerzeichnis;
                    
                    // Nur beim ersten Laden dieses Forms darf die Methode die neueste Datei suchen.
             
                    if (Global.fFormularZaehlerFormular1 == 1)
                    {                   
                        btnDateiAuswahl.Text = NeuePdfDatei.neustePdfDateiAusgeben(Properties.Settings.Default.aktivesVerzeichnis);    
                    }
                    else
                    {
                        btnDateiAuswahl.Text = Properties.Settings.Default.neuesteDatei;
                    }
                    NeuePdfDatei.Name = btnDateiAuswahl.Text;
                    Properties.Settings.Default.neuesteDatei = btnDateiAuswahl.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    btnDateiAuswahl.Text = "Sie haben noch nichts gewählt.";
                    NeuePdfDatei.AktivesVerzeichnis = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    Properties.Settings.Default.aktivesVerzeichnis = NeuePdfDatei.AktivesVerzeichnis;
                    NeuePdfDatei.Name = "";
                }
            }
            else
            {
                if (File.Exists(Properties.Settings.Default.neuesteDatei))
                {
                    NeuePdfDatei.Name = Properties.Settings.Default.neuesteDatei;
                    btnDateiAuswahl.Text = Properties.Settings.Default.neuesteDatei;
                }
                else
                {
                    btnDateiAuswahl.Text = "Sie haben noch nichts gewählt.";
                    NeuePdfDatei.AktivesVerzeichnis = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    NeuePdfDatei.Name = "";
                }
            }

            // Zuerst muss die (evtl. vorhandene) Objektliste aller Nachrichten gelöscht werden.
            // Erst beim Verlassen dieser Seite soll eine frische Objektliste erzeugt werden.

            Global.fNeueNachricht.Clear();

            // Die ComboBox wird initialisiert.
            // Nach dem Laden des Programms steht die ComboBox auf dem Eintrag [Mail-Empfänger].

            cbxEmpfänger.DataSource = Global.fnral;
            cbxEmpfänger.DisplayMember = "NameRegEx";
            cbxEmpfänger.ValueMember = "DefinitionRegEx";
            cbxEmpfänger.ValueMember = "BeschreibungRegEx";
            cbxEmpfänger.ValueMember = "Begrenzer1";
            cbxEmpfänger.ValueMember = "Begrenzer2";

            // Direkt nach Programmstart sollen die Textboxen nur dann mit Werten vorbelegt werden, wenn der entsprechende Haken in den Einstellungen gesetzt ist.
            // Bei der Rückkehr zu diesem Formular innerhalb einer Session sollen die Werte angezeigt werden, die zuvor in der selben Session eingegeben wurden.

            if (Properties.Settings.Default.BodyUndCoZurWiedervorlageSpeichern == true || Global.fFormularZaehlerFormular1 > 1)
            {
                tbxCc.Text = Properties.Settings.Default.cc;
                tbxBcc.Text = Properties.Settings.Default.bcc;
                tbxBetreff.Text = Properties.Settings.Default.betreff;
                tbxBody.Text = Properties.Settings.Default.body;
                tbxAnhang1.Text = Properties.Settings.Default.attachment1;
                tbxAnhang2.Text = Properties.Settings.Default.attachment2;
                tbxAnhang3.Text = Properties.Settings.Default.attachment3;
            }

            // Wenn in den Einstellungen nicht der Haken gesetzt ist, der die Properties wieder herstellen soll,
            // dann werden die Properties beim Laden der Folgesession überschrieben.

            if (Properties.Settings.Default.BodyUndCoZurWiedervorlageSpeichern == false)
            {
                // Nur beim ersten Laden des des Formulars darf es zum Überschreiben der Properties kommen.
                
                if (Global.fFormularZaehlerFormular1 == 1)
                {
                    Properties.Settings.Default.cc = "";
                    Properties.Settings.Default.bcc = "";
                    Properties.Settings.Default.betreff = "";
                    Properties.Settings.Default.body = "";
                    Properties.Settings.Default.attachment1 = tbxAnhang1.Text;
                    Properties.Settings.Default.attachment2 = tbxAnhang2.Text;
                    Properties.Settings.Default.attachment3 = tbxAnhang3.Text;
                    Properties.Settings.Default.Save();    
                }
            }

            if (Properties.Settings.Default.PasswortSpeichern == false)
            {
                Properties.Settings.Default.mailPassword = "";
                Properties.Settings.Default.Save();    
            }
        }

        private void pictureBoxHilfe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://coelina.de");
        }

        private void btnDateiAuswahl_Click(object sender, EventArgs e)
        {
            // Der Dialog zur Auswahl einer beliebigen PDF-Datei wird angeboten.

            Properties.Settings.Default.neuesteDatei = NeuePdfDatei.wähleAnhang(NeuePdfDatei.AktivesVerzeichnis, btnDateiAuswahl.Text);

            // Die Datei ohne Pfad wird in die Textbox eingetragen.

            btnDateiAuswahl.Text = Properties.Settings.Default.neuesteDatei;
            NeuePdfDatei.Name = btnDateiAuswahl.Text;

            Properties.Settings.Default.aktivesVerzeichnis = Path.GetDirectoryName(btnDateiAuswahl.Text);
            Properties.Settings.Default.Save();
        }

        private void btnWeiterZu2_Click(object sender, EventArgs e)
        {           
            // Ein neuer Ordner wird erzeugt, der die zerstückelte PDF-Datei aufnimmt.

            try
            {
                NeuePdfDatei.erstelleOrdner();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: \n Es fehlt die Berechtigung einen Ordner anzulegen, der sodann die Einzelseiten aufnimmt.\n\n"+ex, "Coelina");
                return;
            }
            
            // Die Datei wird zerlegt.

            NeuePdfDatei.zerlegePdfInEinzelseiten(NeuePdfDatei.VollständigerPfadZurDatei);

            string name;

            try
            {
                FileInfo file = new FileInfo(Properties.Settings.Default.neuesteDatei);
                name = file.Name.Substring(0, file.Name.LastIndexOf("."));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: \n\nSie müssen eine PDF-Datei auswählen.\n\n" + ex, "Coelina");
                return;
            }
            
            // Es wird ein Reader für die PDF-Datei erzeugt.

            try
            {
                PdfReader reader = new PdfReader(Properties.Settings.Default.neuesteDatei);

                // Die Anzahl der Seiten der PDF-Datei wird ermittelt.

                int n = reader.NumberOfPages;

                // Die Eigenschaft wird angepasst.

                NeuePdfDatei.AnzahlSeiten = n;
                int digits = 1 + (n / 10);

                // Progressbar einstellen.

                progressBar1.Visible = true;
                progressBar1.Minimum = 1;
                progressBar1.Maximum = n + 1;
                progressBar1.Value = 1;
                progressBar1.Step = 1;
                //progressBar1.PerformStep();

                Document document;
                int pagenumber;
                string filename;


                // Für jede Einzelseite wird mindestens ein Nachrichtenobjekt angelegt.

                for (int i = 0; i < n; i++)
                {
                    pagenumber = i + 1;

                    filename = pagenumber.ToString();
                    while (filename.Length < digits) filename = "0" + filename;
                    filename = "_" + filename + ".pdf";
                    filename = name + filename;

                    // Ein document-Objekt wird erzeugt.

                    document = new Document(reader.GetPageSizeWithRotation(pagenumber));

                    // Ein Writer wird für das document erstellt.

                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(frmSerienbriefdateiWählen.NeuePdfDatei.Unterverzeichnis + "\\" + filename, FileMode.Create));

                    // Öffnen des Dokuments.

                    document.Open();
                    PdfContentByte cb = writer.DirectContent;
                    PdfImportedPage page = writer.GetImportedPage(reader, pagenumber);
                    int rotation = reader.GetPageRotation(pagenumber);
                    if (rotation == 90 || rotation == 270)
                    {
                        cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(pagenumber).Height);
                    }
                    else
                    {
                        cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                    }

                    // Schließen des Dokuments.

                    document.Close();

                    List<string> empfängerMitDuplikaten = NeuePdfDatei.ReadPdfFile(NeuePdfDatei.Unterverzeichnis + "\\" + filename, Global.nral[cbxEmpfänger.SelectedIndex].DefinitionRegEx, Global.nral[cbxEmpfänger.SelectedIndex].Begrenzer1, Global.nral[cbxEmpfänger.SelectedIndex].Begrenzer2, cbxEmpfänger.SelectedIndex);
                    
                    // Duplikate werden entfernt, damit jeder Empfänger jede Seite nur 1x bekommt.

                    List<string> empfänger = empfängerMitDuplikaten.Distinct().ToList();
                    
                    // Für jeden einzelnen Empfänger auf einer Seite wird ein Nachrichtenobjekt angelegt.

                    for (int j = 0; j < empfänger.Count(); j++)
                    {

                        // Falls die Alias-Funktionalität in den Einstellungen aktiv ist, wird nach allen Aliassen in Betreff und Body gesucht und entsprechend ersetzt.

                        string betreff = Properties.Settings.Default.betreff;
                        string body = Properties.Settings.Default.body;
                        string aliasKürzel = "";
                        string aliasName = "";
                        string alias1 = "";
                        string alias2 = "";
                        string alias3 = "";
                        string alias4 = "";
                       
                        
                        // Wenn ein Alias ausgewertet werden soll, muss der Alias erst in eine E-Mail-Adresse übersetzt werden.

                        if (cbxEmpfänger.SelectedIndex != 0)
                        {

                            empfänger[j] = Global.AliasMail.ermittleEmailAdresseAusEinemAlias(empfänger[j], cbxEmpfänger.SelectedIndex);

                            
                            // Objekte mit ""-Wert werden entfernt.    
                        }

                        //empfänger = empfänger.Where(x => x != null).ToList();

                        // Wenn der Alias in den Einstellungen aktiv geschaltet wurde, wird in Betreff und Body nach Alias gesucht und entsprechend ersetzt.

                        if (Properties.Settings.Default.AliasAktiv == true)
                        {
                            foreach (AliasKopfzeile a in Enum.GetValues(typeof(AliasKopfzeile)))
                            {
                                betreff = Global.AliasMail.AliasSuchenUndTextErsetzen(empfänger[j], betreff, "[" + a + "]");
                                body = Global.AliasMail.AliasSuchenUndTextErsetzen(empfänger[j], body, "[" + a + "]");
                            }
                            if (cbxEmpfänger.SelectedIndex == 0)
                            {
                                aliasKürzel = Global.AliasMail.AliasKürzelErmitteln(empfänger[j]);
                            }
                            aliasName = Global.AliasMail.AliasNameErmitteln(empfänger[j]);
                            alias1 = Global.AliasMail.Alias1Ermitteln(empfänger[j]);
                            alias2 = Global.AliasMail.Alias2Ermitteln(empfänger[j]);
                            alias3 = Global.AliasMail.Alias3Ermitteln(empfänger[j]);
                            alias4 = Global.AliasMail.Alias4Ermitteln(empfänger[j]);
                        }

                        // Jetzt wird ein neues Nachrichtenobjekt erzeugt.

                        // Nur, wenn tatsächlich eine gültige E-Mail-Adresse ermittelt werden kann, wird das Nachrichtenobjekt angelegt.
                        if (empfänger[j].Contains('@'))
                        {
                            Global.fNeueNachricht.Add(new Nachricht(Properties.Settings.Default.bcc, betreff, body, Properties.Settings.Default.cc, frmSerienbriefdateiWählen.NeuePdfDatei.Unterverzeichnis + "\\" + filename, empfänger[j], Properties.Settings.Default.attachment1, Properties.Settings.Default.attachment2, Properties.Settings.Default.attachment3, Properties.Settings.Default.mailPassword, Properties.Settings.Default.smtpPort, Properties.Settings.Default.smtpServer, Properties.Settings.Default.absender, aliasName, aliasKürzel, alias1, alias2, alias3, alias4));        
                        }
                                                	                     
                        progressBar1.PerformStep();
                    }   
                }
            }
            catch (Exception ex)
            {
               string fehler = "Die Datei " + NeuePdfDatei.Name + " kann nicht gelesen werden.\nKann es sein, dass die Datei passwortgeschützt ist?\nHier geht es nicht weiter.";
               MessageBox.Show("Fehler: \n" + fehler + "\n\n" + ex, "Coelina");
               return;
            }
            
            // Nur, wenn die PDF-Datei existiert und die SMTP-Einstellungen gültig sind, geht es weiter.

            if (File.Exists(btnDateiAuswahl.Text) && Path.GetExtension(btnDateiAuswahl.Text) == ".pdf" && Global.fNeueNachricht.Count() > 0)
            {
                if (Properties.Settings.Default.MaileinstellungenKorrekt == true)
                {
                    frmVorschau frm2 = new frmVorschau();
                    // frm2 soll innerhalb des MDI-Containers öffnen. Also wird der Parent des aktuellen Forms an das nächste Form übergeben.
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    this.Close();
                }
                else
                {
                    string fehler = "\n\nWechseln Sie zu den Einstellungen, um zuerst einen gültigen SMTP-Zugang einzurichten.\nAnschließend kehren Sie hierher zurück.";
                    MessageBox.Show("Fehler: \n" + fehler, "Coelina");
                    return;
                }
            }
            else
            {
                string fehler = "\nEs muss mindestens ein Empfänger ausgelesen werden können, um zum nächsten Schritt zu kommen.";
                MessageBox.Show("Fehler: \n" + fehler, "Coelina");
                return;
            }
            
            try
            {
                MailAddress m = new MailAddress(tbxCc.Text);
                Properties.Settings.Default.cc = tbxCc.Text;
            }
            catch
            {
                // Wenn die Textbox nicht leer und gleichzeitig nicht mit keiner gültigen Adresse gefüllt ist, dann wird die Zelle geleert
                if (tbxCc.Text != "")
                {
                    Properties.Settings.Default.cc = "";
                    tbxCc.Text = "";
                    string fehler = "\n\nDie CC-Adresse ist nicht gültig und wird ignoriert.";
                    MessageBox.Show("Fehler: \n" + fehler, "Coelina");   
                }
            }

            Properties.Settings.Default.Save();

            try
            {
                MailAddress m = new MailAddress(tbxBcc.Text);
                Properties.Settings.Default.bcc = tbxBcc.Text;
            }
            catch
            {
                // Wenn die Textbox nicht leer und gleichzeitig nicht mit keiner gültigen Adresse gefüllt ist, dann wird die Zelle geleert.

                if (tbxBcc.Text != "")
                {
                    Properties.Settings.Default.bcc = "";
                    tbxBcc.Text = "";
                    string fehler = "\n\nDie BCC-Adresse ist nicht gültig und wird ignoriert.";
                    MessageBox.Show("Fehler: \n" + fehler, "Coelina");
                }
            }
            Properties.Settings.Default.Save();
        }
        
        private void checkBoxImmerNeuesteDateiVorschlagen_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.immerNeuesteDateiVorschlagen = checkBoxImmerNeuesteDateiVorschlagen.Checked;
            Properties.Settings.Default.Save();
        }
        
        private void btnDateiAuswahl_TextChanged_1(object sender, EventArgs e)
        {
            if (File.Exists(btnDateiAuswahl.Text))
            {
                Properties.Settings.Default.neuesteDatei = btnDateiAuswahl.Text;
                Properties.Settings.Default.Save();
            }
        }
        
        private void tbxCc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(tbxCc.Text);
                Properties.Settings.Default.cc = tbxCc.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                Properties.Settings.Default.cc = "";
                Properties.Settings.Default.Save();
            }
        }

        private void tbxBcc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(tbxBcc.Text);
                Properties.Settings.Default.bcc = tbxBcc.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                Properties.Settings.Default.bcc = "";
                Properties.Settings.Default.Save();
            }
        }

        // Prüfen, ob ein Anhang eine ausführbare Datei ist. Es dürfen keine ausführbaren Dateien versandt werden.

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
                    MessageBox.Show("Aus Sicherheitsgründen dürfen keine ausführbaren Dateien versandt werden.", "Coelina");    
                }
                return Encoding.UTF8.GetString(twoBytes) == "MZ";
            }
            catch (Exception)
            {
                return Encoding.UTF8.GetString(twoBytes) != "MZ"; ;
            }
        }

        private void tbxAnhang1_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(tbxAnhang1.Text) || tbxAnhang1.Text == "")
            {
                Properties.Settings.Default.attachment1 = tbxAnhang1.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.attachment1 = "";
                Properties.Settings.Default.Save();
            }
            if (IstEineAusführbareDatei(tbxAnhang1.Text) == true)
            {
                Properties.Settings.Default.attachment1 = "";
                tbxAnhang1.Text = Properties.Settings.Default.attachment1;
                Properties.Settings.Default.Save();
            }
        }

        private void tbxAnhang2_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(tbxAnhang2.Text) || tbxAnhang2.Text == "")
            {
                Properties.Settings.Default.attachment2 = tbxAnhang2.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.attachment2 = "";
                Properties.Settings.Default.Save();
            }
            if (IstEineAusführbareDatei(tbxAnhang2.Text) == true)
            {
                Properties.Settings.Default.attachment2 = "";
                tbxAnhang2.Text = Properties.Settings.Default.attachment2;
                Properties.Settings.Default.Save();
            }
        }

        private void tbxAnhang3_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(tbxAnhang3.Text) || tbxAnhang3.Text == "")
            {
                Properties.Settings.Default.attachment3 = tbxAnhang3.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.attachment3 = "";
                Properties.Settings.Default.Save();
            }
            if (IstEineAusführbareDatei(tbxAnhang3.Text) == true)
            {
                Properties.Settings.Default.attachment3 = "";
                tbxAnhang3.Text = Properties.Settings.Default.attachment3;
                Properties.Settings.Default.Save();
            }           
        }

        private void btnAnhang1_Click(object sender, EventArgs e)
        {
            tbxAnhang1.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Properties.Settings.Default.attachment1 = tbxAnhang1.Text;
            Properties.Settings.Default.Save();
        }

        private void btnAnhang2_Click(object sender, EventArgs e)
        {
            tbxAnhang2.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Properties.Settings.Default.attachment2 = tbxAnhang2.Text;
            Properties.Settings.Default.Save();
        }

        private void btnAnhang3_Click(object sender, EventArgs e)
        {
            tbxAnhang3.Text = this.wähleAnhang(Properties.Settings.Default.aktivesVerzeichnis);
            Properties.Settings.Default.attachment3 = tbxAnhang3.Text;
            Properties.Settings.Default.Save();
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

        private void tbxBody_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.body = tbxBody.Text;
            Properties.Settings.Default.Save();
        }

        private void tbxBetreff_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.betreff = tbxBetreff.Text;
            Properties.Settings.Default.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxKopfzeile_Enter(object sender, EventArgs e)
        {

        }
        string zielverzeichnis ="";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
            string url = @"http://www.coelina.de/testdatei.pdf";

            string eigeneDateien = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            zielverzeichnis = Path.Combine(eigeneDateien, "testdatei.pdf");

            WebClient client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

            // Start the download and copy the file to c:\temp
            client.DownloadFileAsync(new Uri(url), zielverzeichnis);

            Properties.Settings.Default.neuesteDatei = zielverzeichnis;

            // Die Datei ohne Pfad wird in die Textbox eingetragen.

            btnDateiAuswahl.Text = Properties.Settings.Default.neuesteDatei;
            
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Testdatei heruntergeladen nach \n" + zielverzeichnis + "\nSie können diese Meldung schließen und dann \"Weiter zu Schritt 2\" klicken.","Coelina");
        }

        private void cbxEmpfänger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}