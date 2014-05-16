using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coelina
{
    public class SmtpEinstellungen
    {
        private string fUser;

        public string User
        {
            get { return fUser; }
            set { fUser = value; }
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
        private string fAbsender;

        public string Absender
        {
            get { return fAbsender; }
            set { fAbsender = value; }
        }
        private string fPasswort;

        public string Passwort
        {
            get { return fPasswort; }
            set { fPasswort = value; }
        }

        public bool validiereMailAdresse()
        {
            throw new System.NotImplementedException();
        }
    }
}
