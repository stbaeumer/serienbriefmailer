using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Coelina
{
    [Serializable]
    public class RegulärerAusdruck
    {
        private string fNameRegEx;

        public string NameRegEx
        {
            get { return fNameRegEx; }
            set { fNameRegEx = value; }
        }
        private string fDefinitionRegEx;

        public string DefinitionRegEx
        {
            get { return fDefinitionRegEx; }
            set { fDefinitionRegEx = value; }
        }

        private string fBeschreibungRegEx;

        public string BeschreibungRegEx
        {
            get { return fBeschreibungRegEx; }
            set { fBeschreibungRegEx = value; }
        }

        private string fBegrenzer1;

        public string Begrenzer1
        {
            get { return fBegrenzer1; }
            set { fBegrenzer1 = value; }
        }

        private string fBegrenzer2;

        public string Begrenzer2
        {
            get { return fBegrenzer2; }
            set { fBegrenzer2 = value; }
        }

        
        public RegulärerAusdruck(string pName, string pDefinition, string pBeschreibung, string pBegrenzer1, string pBegrenzer2)
        {
            fNameRegEx = pName;
            fDefinitionRegEx = pDefinition;
            fBeschreibungRegEx = pBeschreibung;
            fBegrenzer1 = pBegrenzer1;
            fBegrenzer2 = pBegrenzer2;
        }

        public RegulärerAusdruck()
        {

        }

       

    }
}
