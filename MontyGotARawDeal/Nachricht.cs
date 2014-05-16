using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Coelina
{
    public class Nachricht : SmtpEinstellungen
    {
        private string fSmtp;
        public string Smtp
        {
            get { return fSmtp; }
            set { fSmtp = value; }
        }

        private int fPort;
        public int Port
        {
            get { return fPort; }
            set { fPort = value; }
        }

        private string fUser;
        public string User
        {
            get { return fUser; }
            set { fUser = value; }
        }

        private string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { fPassword = value; }
        }

        private string fBetreff;
        public string Betreff
        {
            get { return fBetreff; }
            set { fBetreff = value; }
        }

        private string fBody;
        public string Body
        {
            get { return fBody; }
            set { fBody = value; }
        }
        
        private string fDateianhang;
        public string Dateianhang
        {
            get { return fDateianhang; }
            set { fDateianhang = value; }
        }

        private string fEmpfänger;
        public string Empfänger
        {
            get { return fEmpfänger; }
            set { fEmpfänger = value; }
        }

        private string fBcc;
        public string Bcc
        {
            get { return fBcc; }
            set { fBcc = value; }
        }

        private string fcc;
        public string cc
        {
            get { return fcc; }
            set { fcc = value; }
        }

        private string fOptionalerAnhang1;
        public string OptionalerAnhang1
        {
            get { return fOptionalerAnhang1; }
            set { fOptionalerAnhang1 = value; }
        }

        private string fOptionalerAnhang2;
        public string OptionalerAnhang2
        {
            get { return fOptionalerAnhang2; }
            set { fOptionalerAnhang2 = value; }
        }

        private string fOptionalerAnhang3;
        public string OptionalerAnhang3
        {
            get { return fOptionalerAnhang3; }
            set { fOptionalerAnhang3 = value; }
        }

        private string fAliasName;

        public string AliasName
        {
            get { return fAliasName; }
            set { fAliasName = value; }
        }
        private string fAliasKürzel;

        public string AliasKürzel
        {
            get { return fAliasKürzel; }
            set { fAliasKürzel = value; }
        }
        private string fAlias1;

        public string Alias1
        {
            get { return fAlias1; }
            set { fAlias1 = value; }
        }
        private string fAlias2;

        public string Alias2
        {
            get { return fAlias2; }
            set { fAlias2 = value; }
        }
        private string fAlias3;

        public string Alias3
        {
            get { return fAlias3; }
            set { fAlias3 = value; }
        }
        private string fAlias4;

        public string Alias4
        {
            get { return fAlias4; }
            set { fAlias4 = value; }
        }


        public Nachricht(string pBcc, string pBetreff, string pBody, string pCC, string pDateianhang, string pEmpfänger, string pOptionalerAnhang1, string pOptionalerAnhang2, string pOptionalerAnhang3, string pPassword, int pPort, string pSmtp, string pUser)
        {
            fBcc = pBcc;
            fcc = pCC;
            fEmpfänger = pEmpfänger;
            fBetreff = pBetreff;
            fBody = pBody;
            fDateianhang = pDateianhang;
            fOptionalerAnhang1 = pOptionalerAnhang1;
            fOptionalerAnhang2 = pOptionalerAnhang2;
            fOptionalerAnhang3 = pOptionalerAnhang3;
            fSmtp = pSmtp;
            fUser = pUser; 
        }

        public Nachricht(string pBcc, string pBetreff, string pBody, string pCC, string pDateianhang, string pEmpfänger, string pOptionalerAnhang1, string pOptionalerAnhang2, string pOptionalerAnhang3, string pPassword, int pPort, string pSmtp, string pUser, string pAliasName, string pAliasKürzel, string pAlias1, string pAlias2, string pAlias3, string pAlias4)
        {
            fBcc = pBcc;
            fcc = pCC;
            fEmpfänger = pEmpfänger;
            fBetreff = pBetreff;
            fBody = pBody;
            fDateianhang = pDateianhang;
            fOptionalerAnhang1 = pOptionalerAnhang1;
            fOptionalerAnhang2 = pOptionalerAnhang2;
            fOptionalerAnhang3 = pOptionalerAnhang3;
            fSmtp = pSmtp;
            fUser = pUser;
            fAlias1 = pAlias1;
            fAlias2 = pAlias2;
            fAlias3 = pAlias3;
            fAliasName = pAliasName;
            fAliasKürzel = pAliasKürzel;
        }


        public Nachricht()
        {

        }

        public string versenden(string empfänger,string cc,string bcc,string betreff,string body,string dateianhang,string optinalerAnhang1,string optinalerAnhang2,string optinalerAnhang3)
        {
            MailMessage neueNachricht = new MailMessage();
            MailAddress absender = new MailAddress(Properties.Settings.Default.absender);
            
            neueNachricht.To.Add(empfänger);                        
            neueNachricht.From = absender;
            neueNachricht.Subject = betreff;
            neueNachricht.Body = body;

            neueNachricht.IsBodyHtml = Properties.Settings.Default.mailsAlsHtmlSenden;    
                        
            if (bcc.Length > 0)
            {
                neueNachricht.Bcc.Add(bcc);
            }
            
            // Wenn in den Einstellungen vorgesehen ist, dass von jeder E-Mail eine BlindCopy gesendet werden soll ...

            if (Properties.Settings.Default.BlindCopyAn != "")
            {
                //neueNachricht.Bcc.Add(Properties.Settings.Default.BlindCopyAn);
            }
                        
            
            if (dateianhang.Length > 0)
            {
               neueNachricht.Attachments.Add(new Attachment(dateianhang)); 
            }            
            if (optinalerAnhang1.Length  >= 5) 
                neueNachricht.Attachments.Add(new Attachment(optinalerAnhang1));
            if (optinalerAnhang2.Length >= 5)
                neueNachricht.Attachments.Add(new Attachment(optinalerAnhang2)); 
            if (optinalerAnhang3.Length >= 5)
                neueNachricht.Attachments.Add(new Attachment(optinalerAnhang3));
            
            SmtpClient client;

            try
            {
                client = new SmtpClient(Properties.Settings.Default.smtpServer, Properties.Settings.Default.smtpPort);
                client.Timeout = 7000;

                try
                {
                    System.Net.NetworkCredential nc = new System.Net.NetworkCredential(Properties.Settings.Default.absender, Properties.Settings.Default.mailPassword);
                    client.Credentials = nc;
                    client.EnableSsl = Properties.Settings.Default.SSLEinschalten;
                    client.Send(neueNachricht);
                    return "\nGesendet: " + empfänger + " um " + DateTime.Now.ToString() + ".";
                }
                catch (Exception)
                {
                    return "\n**FEHLER: " + empfänger + " um " + DateTime.Now.ToString() + ".";
                }
            }
            catch (Exception)
            {
                return "\n**FEHLER: " + empfänger + " um " + DateTime.Now.ToString() + ".";
            }

            
        }

            public string testmailSenden(string empfänger)
            {
                MailMessage testmail = new MailMessage();
                testmail.From = new MailAddress(Properties.Settings.Default.absender);
                testmail.To.Add(empfänger);
                testmail.Subject = "Test-E-Mail von Coelina-Serienbrief-Mailer";
                testmail.Body = "Der E-Mail-Versand funktioniert.";
                testmail.IsBodyHtml = Properties.Settings.Default.mailsAlsHtmlSenden;    

                SmtpClient client;
                                
                try
                {
                    client = new SmtpClient(Properties.Settings.Default.smtpServer, Properties.Settings.Default.smtpPort);
                    client.Timeout = 7000;

                    try
                    {
                        System.Net.NetworkCredential nc = new System.Net.NetworkCredential(Properties.Settings.Default.absender, Properties.Settings.Default.mailPassword);
                        client.Credentials = nc;
                        client.EnableSsl = Properties.Settings.Default.SSLEinschalten;
                        client.Send(testmail);
                    }
                    catch (Exception ex)
                    {
                        return string.Format("Fehler: \n\nEs gibt Probleme beim Versand. Eine häufige Fehlerquelle ist die Firewall. Achten Sie darauf, dass der ausgehende Port geöffnet ist. Stimmen die SMTP-Einstellungen? \n\nFehlercode:{0}", ex, "Coelina");
                    }
                    
                    return "Die Einstellungen scheinen zu stimmen.";
                }                
                catch (Exception ex)
                {
                    return string.Format("Monty Got A Raw Deal.\n\nFehlercode:{0}", ex);
                }
            }

            public string wähleAnhang(string initialDirectory)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Dateien (*.*)|*.*|All files (*.*)|*.*";
                dialog.InitialDirectory = initialDirectory;
                dialog.Title = "Wählen Sie eine Datei!";
                return (dialog.ShowDialog() == DialogResult.OK)
                   ? dialog.FileName : null;
            }
    }
}
