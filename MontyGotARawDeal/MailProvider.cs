using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coelina
{
    public class MailProvider
    {
        private string fName;

        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }
        private string fSmtpServer;

        public string SmtpServer
        {
            get { return fSmtpServer; }
            set { fSmtpServer = value; }
        }
        private int fSmtpPort;

        public int SmtpPort
        {
            get { return fSmtpPort; }
            set { fSmtpPort = value; }
        }
        private bool fSslEinschalten;

        public bool SslEinschalten
        {
            get { return fSslEinschalten; }
            set { fSslEinschalten = value; }
        }
        private string fUser;

        public string User
        {
            get { return fUser; }
            set { fUser = value; }
        }

        public MailProvider(string pName, string pSmtpServer, int pSmtpPort, string pUser, bool pSslEinschalten)
        {
            fName = pName;
            fSmtpServer = pSmtpServer;
            fSmtpPort = pSmtpPort;
            fUser = pUser;
            fSslEinschalten = pSslEinschalten;

        }
    }
}
