using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Coelina
{
    public class Log
    {
        private string fLogDateiVerzeichnis;

        public string LogDateiVerzeichnis
        {
            get { return fLogDateiVerzeichnis; }
            set { fLogDateiVerzeichnis = value; }
        }
        private string fLogDateiName;

        public string LogDateiName
        {
            get { return fLogDateiName; }
            set { fLogDateiName = value; }
        }
        private string fLogDateiDateiendung;

        public string LogDateiDateiendung
        {
            get { return fLogDateiDateiendung; }
            set { fLogDateiDateiendung = value; }
        }
        private string fZeitstempel;

        public string Zeitstempel
        {
            get { return fZeitstempel; }
            set { fZeitstempel = value; }
        }

        private int fSpaltenIndex1;

        public int SpaltenIndex1
        {
            get { return fSpaltenIndex1; }
            set { fSpaltenIndex1 = value; }
        }
        private int fSpaltenIndex2;

        public int SpaltenIndex2
        {
            get { return fSpaltenIndex2; }
            set { fSpaltenIndex2 = value; }
        }
        private int fSpaltenIndex3;

        public int SpaltenIndex3
        {
            get { return fSpaltenIndex3; }
            set { fSpaltenIndex3 = value; }
        }
        private int fSpaltenIndex4;

        public int SpaltenIndex4
        {
            get { return fSpaltenIndex4; }
            set { fSpaltenIndex4 = value; }
        }
        private int fSpaltenIndex5;

        public int SpaltenIndex5
        {
            get { return fSpaltenIndex5; }
            set { fSpaltenIndex5 = value; }
        }
        private int fSpaltenIndex6;

        public int SpaltenIndex6
        {
            get { return fSpaltenIndex6; }
            set { fSpaltenIndex6 = value; }
        }

        private string fKopfzeile;

        public string Kopfzeile
        {
            get { return fKopfzeile; }
            set { fKopfzeile = value; }
        }

        private string fEmpfänger;

        public string Empfänger
        {
            get { return fEmpfänger; }
            set { fEmpfänger = value; }
        }
        private string fDateiAnhang;

        public string DateiAnhang
        {
            get { return fDateiAnhang; }
            set { fDateiAnhang = value; }
        }

        private string fKürzel;

        public string Kürzel
        {
            get { return fKürzel; }
            set { fKürzel = value; }
        }

        
        public Log(string pEmpfänger, string pDateianhang, string pZeitstempel, string pKürzel)
        {
            fKürzel = pKürzel;
            fEmpfänger = pEmpfänger;
            fDateiAnhang = pDateianhang;
            fZeitstempel = pZeitstempel;
        }

        public Log(int pSpaltenindex1,int pSpaltenindex2, int pSpaltenindex3, int pSpaltenindex4, int pSpaltenindex5, int pSpaltenindex6)
        {
            fSpaltenIndex1 = pSpaltenindex1;
            fSpaltenIndex2 = pSpaltenindex2;
            fSpaltenIndex3 = pSpaltenindex3;
            fSpaltenIndex4 = pSpaltenindex4;
            fSpaltenIndex5 = pSpaltenindex5;
            fSpaltenIndex6 = pSpaltenindex6;
        }


        public bool LogdateiAnlegenFallsNichtVorhanden(string pPfad,string pDateiName, string pDateiendung)
        {
            if (!File.Exists(Properties.Settings.Default.LogDatei))
            {
                string eigeneDateien = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string montyLog =  eigeneDateien + "\\monty.log";
                File.CreateText(montyLog);
                Properties.Settings.Default.LogDatei = montyLog;
                Properties.Settings.Default.Save();
            }

            return true; 
        }
    }
}
