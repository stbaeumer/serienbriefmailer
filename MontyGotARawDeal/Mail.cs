//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Net.Mail;
//using System.Windows.Forms;

//namespace Coelina
//{
//    public class Mail
//    {
//        private string fBody;

//        public string Body
//        {
//            get { return fBody; }
//            set { fBody = value; }
//        }
//        private string fBetreff;

//        public string Betreff
//        {
//            get { return fBetreff; }
//            set { fBetreff = value; }
//        }
//        private string fSmtp;

//        public string Smtp
//        {
//            get { return fSmtp; }
//            set { fSmtp = value; }
//        }
//        private string fUser;

//        public string User
//        {
//            get { return fUser; }
//            set { fUser = value; }
//        }
//        private string fPassword;

//        public string Password
//        {
//            get { return fPassword; }
//            set { fPassword = value; }
//        }
//        private string fDateianhang;

//        public string Dateianhang
//        {
//            get { return fDateianhang; }
//            set { fDateianhang = value; }
//        }

//        private string fEmpfänger;

//        public string Empfänger
//        {
//            get { return fEmpfänger; }
//            set { fEmpfänger = value; }
//        }

//        private string fBcc;

//        public string Bcc
//        {
//            get { return fBcc; }
//            set { fBcc = value; }
//        }

//        private string fcc;

//        public string cc
//        {
//            get { return fcc; }
//            set { fcc = value; }
//        }

//        private int fPort;

//        public int Port
//        {
//            get { return fPort; }
//            set { fPort = value; }
//        }

//        private string fOptionalerAnhang1;

//        public string OptionalerAnhang1
//        {
//            get { return fOptionalerAnhang1; }
//            set { fOptionalerAnhang1 = value; }
//        }
//        private string fOptionalerAnhang2;

//        public string OptionalerAnhang2
//        {
//            get { return fOptionalerAnhang2; }
//            set { fOptionalerAnhang2 = value; }
//        }
//        private string fOptionalerAnhang3;

//        public string OptionalerAnhang3
//        {
//            get { return fOptionalerAnhang3; }
//            set { fOptionalerAnhang3 = value; }
//        }


//        public string versenden()
//        {
//            MailMessage neueNachricht = new MailMessage();
//            MailAddress absender = new MailAddress(Properties.Settings.Default.absender);
//            neueNachricht.To.Add(this.Empfänger);
//            neueNachricht.From = absender;
//            neueNachricht.Subject = this.Betreff;
//            neueNachricht.Body = this.Body;
//            neueNachricht.Bcc.Add(Properties.Settings.Default.bcc);
            
            
//            neueNachricht.Attachments.Add(new Attachment(this.Dateianhang));

//            // Anhänge werden nur dann berücksichtigt, wenn sie mindestens 5 Zeichen lang sind.
//            if (this.OptionalerAnhang1.Length >= 5) 
//                neueNachricht.Attachments.Add(new Attachment(this.OptionalerAnhang1));
//            if (this.OptionalerAnhang2.Length >= 5)
//                neueNachricht.Attachments.Add(new Attachment(this.OptionalerAnhang2)); 
//            if (this.OptionalerAnhang3.Length >= 5)
//                neueNachricht.Attachments.Add(new Attachment(this.OptionalerAnhang3));
                
//            string host = Properties.Settings.Default.smtpServer;
//            int port = Convert.ToInt32(Properties.Settings.Default.smtpPort);
//            SmtpClient client = new SmtpClient(host, port);

//            System.Net.NetworkCredential nc = new System.Net.NetworkCredential(Properties.Settings.Default.mailUser, Properties.Settings.Default.mailPassword);
//            client.Credentials = nc;
//            try
//            {
//                client.Send(neueNachricht);
//                return "\nGesendet: " + this.Empfänger + " um " + DateTime.Now.ToString() + ".";
//            }
//            catch (Exception)
//            {
//                System.Windows.Forms.MessageBox.Show("Es kann keine Mail versendet werden. \n Überprüfen Sie die Einstellungen!");
//                return "Hallo";
//            }
//        }
        
//        public string wähleAnhang(string initialDirectory)
//        {
//            OpenFileDialog dialog = new OpenFileDialog();
//            dialog.Filter = "Dateien (*.*)|*.*|All files (*.*)|*.*";
//            dialog.InitialDirectory = initialDirectory;
//            dialog.Title = "Wählen Sie eine Datei!";
//            return (dialog.ShowDialog() == DialogResult.OK)
//               ? dialog.FileName : null;
//        }
        

//        public Mail(string pBody, string pBetreff, string pDateianhang, string pSmtp, string pUser, string pPassword,string pEmpfänger, string pBcc, int pPort)
//        {
//            fPort = pPort;
//            fBcc = pBcc;
//            fBody = pBody;
//            fBetreff = pBetreff;
//            fDateianhang = pDateianhang;
//            fSmtp = pSmtp;
//            fUser = pUser;
//            fPassword = pPassword;
//            fEmpfänger = pEmpfänger;
//            fDateianhang = pDateianhang;   
//        }

//        public Mail()
//        {
         
//        }

//        public Mail(string pSmtp, string pUser, string pPassword, int pPort)
//        {
//            fPort = pPort;
//            fSmtp = pSmtp;
//            fUser = pUser;
//            fPassword = pPassword;
//        }
//    }
//}
