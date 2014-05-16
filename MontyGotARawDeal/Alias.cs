using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coelina
{
    public class Alias
    {
        private string fEmail;

        public string Email
        {
            get { return fEmail; }
            set { fEmail = value; }
        }
        private string fKürzel;

        public string Kürzel
        {
            get { return fKürzel; }
            set { fKürzel = value; }
        }
        private string fName;

        public string Name
        {
            get { return fName; }
            set { fName = value; }
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

        public Alias(string pMail, string pKürzel, string pName, string pAlias1, string pAlias2, string pAlias3, string pAlias4)
        {
            fEmail = pMail;
            fName = pName;
            fKürzel = pKürzel;
            fAlias1 = pAlias1;
            fAlias2 = pAlias2;
            fAlias3 = pAlias3;
            fAlias4 = pAlias4;
        }
    }
}
