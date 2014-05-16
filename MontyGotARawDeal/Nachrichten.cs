using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coelina
{
    public class Nachrichten:List<Nachricht>
    {
        private int fAnzahlEmpfänger;
         
        public int AnzahlEmpfänger
        {
            get { return fAnzahlEmpfänger; }
            set { fAnzahlEmpfänger = value; }
        }
        private int fAnzahlBcc;

        public int AnzahlBcc
        {
            get { return fAnzahlBcc; }
            set { fAnzahlBcc = value; }
        }
        private int fAnzahlCC;

        public int AnzahlCC
        {
            get { return fAnzahlCC; }
            set { fAnzahlCC = value; }
        }

        public void ermittleAnzahlEmpfänger()
        {
            fAnzahlEmpfänger = 0;
            fAnzahlCC = 0;
            fAnzahlBcc = 0;
                        
            for (int i = 0; i < this.Count(); i++)
            {
                if (this[i].Empfänger.Length > 1)
                {
                    fAnzahlEmpfänger++;                    
                    if (this[i].Bcc.Length > 1 & this[i].Empfänger.Length>1)
                    {
                        fAnzahlBcc++;
                    }
                    if (this[i].cc.Length > 1)
                    {
                        fAnzahlCC++;
                    }
                }
                i++;
            }              
        }
        
   
    }
}
