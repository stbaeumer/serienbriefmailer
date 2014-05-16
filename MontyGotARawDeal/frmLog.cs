using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        string cc;
        string bcc;
        string betreff;
        string body;
        string dateianhang;
        string optinalerAnhang1;
        string optinalerAnhang2;
        string optinalerAnhang3;
        string smtpServer;
        int smtpPort;
        string absender;
        string passwort;
        string kürzel;

        private void frmLog_Load(object sender, EventArgs e)
        {
            groupBox3.Text = "Jetzt senden ...";
            listView1.View = View.Details;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
            this.senden();

            


            if (Properties.Settings.Default.NachVersandDateienLöschen == true)
	        {
                //todo: Das Löschen des Verzeichnisses
                //string zuLöschendesVerzeichnis = Global.fNeuePdfDatei.Unterverzeichnis;
                //System.IO.Directory.Delete(zuLöschendesVerzeichnis);
	        }
        }


        private void LogListeSortieren(string pSortierkriterium)
        {
            if (pSortierkriterium == "Kürzel")
            {
                Global.fLogs.Sort((x, y) => x.Kürzel.CompareTo(y.Kürzel));
            }
            if (pSortierkriterium == "E-Mail")
            {
                Global.fLogs.Sort((x, y) => x.Empfänger.CompareTo(y.Empfänger));
            }
            if (pSortierkriterium == "Zeit")
            {
                Global.fLogs.Sort((x, y) => x.Zeitstempel.CompareTo(y.Zeitstempel));
            }
            if (pSortierkriterium == "Dateiname")
            {
                Global.fLogs.Sort((x, y) => x.DateiAnhang.CompareTo(y.DateiAnhang));
            }
        }
        
             


        private void senden()
        {
            string fusszeile;

            if (Properties.Settings.Default.mailsAlsHtmlSenden == true)
            {
                fusszeile = "<br><br><br><br><br><br><br><br><br><br>Versand dieser Nachricht mit dem <a href=\"http://www.coelina.de\">Coelina-Serienbrief-Mailer</<a>.";
            }
            else
            {
                fusszeile = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nVersand dieser Nachricht mit dem Coelina-Serienbrief-Mailer, www.coelina.de";
            }
                
            // Zähler für die Listview

            int z = 0;

            // Wenn die Logdatei noch nicht existiert, wird sie erstellt.

            if (!File.Exists(Properties.Settings.Default.LogDatei))
            {
                string eigeneDateien = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //string coelinaLog = eigeneDateien + "\\coelina.log";
                string coelinaLog = eigeneDateien + "\\"+ Properties.Settings.Default.LogdateiName+"."+Properties.Settings.Default.LogdateiDateiendung;
                File.CreateText(coelinaLog);
                Properties.Settings.Default.LogDatei = coelinaLog;
                Properties.Settings.Default.Save();
            }

            //int n = frmSerienbriefdateiWählen.NeuePdfDatei.AnzahlSeiten;

            int n = Global.fNeueNachricht.Count();

            // Progressbar einstellen

            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = n+1;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            progressBar1.PerformStep();

            for (int i = 0; i < n; i++)
            {
                //  Falls keine Empfänger-Adresse ausgelesen werden konnte, findet auch kein Versand statt.

                if (Global.fNeueNachricht[i].Empfänger.Length > 1 && Global.fNeueNachricht[i].Empfänger != "Diese Nachricht wurde von Ihnen gelöscht.")
                {
                    System.Threading.Thread.Sleep(5000);
                    
                    string empfaenger = Global.fNeueNachricht[i].Empfänger;
                    cc = Global.fNeueNachricht[i].cc;
                    bcc = Global.fNeueNachricht[i].Bcc;
                    betreff = Global.fNeueNachricht[i].Betreff;
                    body = Global.fNeueNachricht[i].Body;

                    // Der Zeilenumbruch \n wird nach HTML konvertiert.
                    body = body.Replace("\n", "<br>");

                    dateianhang = Global.fNeueNachricht[i].Dateianhang;
                    optinalerAnhang1 = Global.fNeueNachricht[i].OptionalerAnhang1;
                    optinalerAnhang2 = Global.fNeueNachricht[i].OptionalerAnhang2;
                    optinalerAnhang3 = Global.fNeueNachricht[i].OptionalerAnhang3;
                    smtpServer = Global.fNeueNachricht[i].Smtp;
                    smtpPort = Global.fNeueNachricht[i].Port;
                    absender = Global.fNeueNachricht[i].User;
                    passwort = Global.fNeueNachricht[i].Password;
                    kürzel = Global.fNeueNachricht[i].AliasKürzel;

                    // Jetzt findet der Versand statt.
                    // MessageBox.Show("Empfänger:" + empfaenger +".\ncc:"+cc+".\nbcc:"+bcc+".");
                    Global.fNeueNachricht[i].versenden(empfaenger, cc, bcc, betreff, body + fusszeile, dateianhang, optinalerAnhang1, optinalerAnhang2, optinalerAnhang3);
                    
                    // Ein neues Log-Objekt wird angeleget.
                    
                    Global.fLogs.Add(new Log(empfaenger, dateianhang, DateTime.Now.ToLongTimeString(), kürzel));
                                        
                    // Eintrag in die Listview vornehmen.

                    z++;
                    string[] zeileFürZeile = {empfaenger, dateianhang, z.ToString("000") };
                    listView1.Items.Add(DateTime.Now.ToLongTimeString()).SubItems.AddRange(zeileFürZeile);
                    listView1.Refresh();

                    // Eintrag in die Logdatei

                    ////logDatei.WriteLine(kürzel+ ", " + DateTime.Now.ToLongTimeString() + ", " + empfaenger + ", " + dateianhang);

                    // Im Falle von bcc und / oder cc werden weitere Mails gesendet.

                    if (cc != "")
                    {
                        Global.fNeueNachricht[i].versenden(cc, "", "", betreff, body + fusszeile, dateianhang, optinalerAnhang1, optinalerAnhang2, optinalerAnhang3);

                        // Eintag in die Listview vornehmen.

                        z++;
                        string[] zeileFürZeile1 = {cc, dateianhang, z.ToString("000") };
                        listView1.Items.Add(DateTime.Now.ToLongTimeString()).SubItems.AddRange(zeileFürZeile1);
                        listView1.Refresh();

                        // Eintrag in die Logdatei

                        if (Properties.Settings.Default.CCundBCCinLogDateiSchreiben == true)
                        {
                            ////logDatei.WriteLine(DateTime.Now.ToLongTimeString() + ", " + cc + ", " + dateianhang);

                            // Ein neues Log-Objekt wird angeleget.

                            Global.fLogs.Add(new Log(cc, dateianhang, DateTime.Now.ToLongTimeString(), kürzel));                            
                        }
                    }
                    if (bcc != "")
                    {
                        Global.fNeueNachricht[i].versenden(bcc, "", "", betreff, body + fusszeile, dateianhang, optinalerAnhang1, optinalerAnhang2, optinalerAnhang3);

                        // Ein neues Log-Objekt wird angeleget.

                        // Global.fLogs.Add(new Log(bcc, dateianhang, DateTime.Now.ToLongTimeString(), kürzel));  

                        // Eintag in die Listview vornehmen

                        z++;
                        string[] zeileFürZeile2 = { bcc, dateianhang, z.ToString("000") };
                        listView1.Items.Add(DateTime.Now.ToLongTimeString()).SubItems.AddRange(zeileFürZeile2);
                        listView1.Refresh();

                        // Eintrag in die Logdatei

                        if (Properties.Settings.Default.CCundBCCinLogDateiSchreiben == true)
                        {
                            ////logDatei.WriteLine(DateTime.Now.ToLongTimeString() + ", " + bcc + ", " + dateianhang);

                            // Ein neues Log-Objekt wird angeleget.

                            Global.fLogs.Add(new Log(bcc, dateianhang, DateTime.Now.ToLongTimeString(), kürzel ));
                        }
                    }
                }

                this.LogListeSortieren(Properties.Settings.Default.SortierkriteriumLogdatei);

                // Die Fortschrittsanzeige wird erstellt.
                progressBar1.PerformStep();
            }

            

            // Ggfs. Lodatei um eine weitere Zeile ergänzen.

            if (Properties.Settings.Default.maillogSenden == true)
            {
                if (Properties.Settings.Default.CCundBCCinLogDateiSchreiben == true)
                {
                    // Ein neues Log-Objekt wird angelegt.

                    //logDatei.WriteLine(DateTime.Now.ToLongTimeString() + ", Logs an " + Properties.Settings.Default.absender + " gesendet.");

                    // Ein neues Log-Objekt wird angeleget.

                    Global.fLogs.Add(new Log(Properties.Settings.Default.absender, dateianhang, DateTime.Now.ToLongTimeString(), kürzel));
                }
            }

            // Logdatei nach dem Schreiben schließen.

            //logDatei.Close();
            //log.Close();

            // Ggfs. Lodatei an den Absender schicken.

            //MessageBox.Show(anzeige);

            // in die Logdatei schreiben:
            try
            {
                FileStream log = new FileStream(Properties.Settings.Default.LogDatei, FileMode.Create, FileAccess.Write);
                StreamWriter logDatei = new StreamWriter(log);

                int i = Global.Logs.Count();
                int j = 0;

                if (logDatei.BaseStream.Position == 0)
                {
                    string jetzt = DateTime.Now.ToString();
                    logDatei.WriteLine(jetzt+"\n");  // Only write header in a new empty file.
                }
                  
                logDatei.WriteLine(Properties.Settings.Default.kopfDerLogdatei + "\n\n");

                while (j < i)
                {
                    string komma = "  ";
                    if (Global.fLogs[j].Kürzel != "  ")
                    {
                        komma = ", ";
                    }

                    string datei = Path.GetFileName(Global.fLogs[j].DateiAnhang);

                    logDatei.WriteLine(Global.fLogs[j].Kürzel + komma + Global.fLogs[j].Empfänger + ", " + Global.fLogs[j].Zeitstempel + ", " + datei);
                    j++;
                }

                logDatei.Close();

                log.Close();

                if (Properties.Settings.Default.maillogSenden == true)
                {
                    Nachricht logMail = new Nachricht();
                    logMail.versenden(Properties.Settings.Default.absender, "", "", "Coelina salutes you!", "Anbei die Logdatei.", Properties.Settings.Default.LogDatei, "", "", "");
                    MessageBox.Show("Versand ok. Sofern sie eine Kopie an sich selbst geschickt haben, schauen Sie in Ihr Postfach.", "Coelina");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Die Logdatei ist schreibgeschützt\n" + ex, "Coelina");
            }
            
            groupBox3.Text = "Gesendet.";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Programm öffnen:
            try
            {
                Process.Start("notepad.exe", Properties.Settings.Default.LogDatei);
                //Properties.Settings.Default.LogDatei = Properties.Settings.Default.LogDatei;
                //Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Die Datei " + Properties.Settings.Default.LogDatei + " kann nicht gefunden werden.\n Überprüfen Sie die Einstellungen.", "Coelina");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.coelina.de");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
