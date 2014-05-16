using Coelina.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public static class Global
    {

        // Die regulären Ausdrücke sollen auf meherern Formularen verfügbar sein.
        // Deswegen kommen sie in eine globale Klasse.

        public static ReguläreAusdrücke fnral;

        public static ReguläreAusdrücke nral
        {
            get { return Global.fnral; }
            //set { Global.fnral = value; }
        }

        public static PdfDatei fNeuePdfDatei;

        public static PdfDatei NeuePdfDatei
        {
            get { return Global.fNeuePdfDatei; }
            set { Global.fNeuePdfDatei = value; }
        
        }

        public static Nachrichten fNeueNachricht;

        public static Nachrichten NeueNachricht
        {
            get { return Global.fNeueNachricht; }
            set { Global.fNeueNachricht = value; }
        }

        public static void InitNachrichten()
        { 
            fNeueNachricht = new Nachrichten();
        }

        public static LogListe fLogs;

        public static LogListe Logs
        {
            get { return Global.fLogs; }
            set { Global.fLogs = value; }
        }
        
        public static void InitLog()
        {
            Logs = new LogListe();
            //Logs.Add(new Log(Properties.Settings.Default.LogSpaltenIndex1, 
            //    Properties.Settings.Default.LogSpaltenIndex2, 
            //    Properties.Settings.Default.LogSpaltenIndex3, 
            //    Properties.Settings.Default.LogSpaltenIndex4, 
            //    Properties.Settings.Default.LogSpaltenIndex5, 
            //    Properties.Settings.Default.LogSpaltenIndex6));
        }

        private static AliasListe fAliasMail;

        public static AliasListe AliasMail
        {
            get { return Global.fAliasMail; }
            set { Global.fAliasMail = value; }
        }

        public static void InitAlias()
        {
            AliasMail = new AliasListe();

                string aliasliste = Properties.Settings.Default.AliasListe;

                // Leerzeichen ...

                aliasliste = aliasliste.Replace(" ,",",");
                aliasliste = aliasliste.Replace("  ", "");
                aliasliste = aliasliste.Replace(", ", ",");

                // 

                aliasliste = aliasliste.TrimEnd(';');

                string[] datensatz = aliasliste.Split(';');
            
                try
                {
                    for (int i = 0; i < datensatz.Length; i++)
                    {
                        string[] parts = datensatz[i].Split(',');
                        Global.AliasMail.Add(new Alias(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]));
                    }
                }
                catch (Exception)
                {
                }
        }

        // Einzelne Formulare soll ihre Erscheinung ändern, wenn sie innerhalb einer Session wiederholt aufgerufen werden.
        // Dafür wird ein Zähler deklariert.
        public static int fFormularZaehlerFormular1;
        public static int fFormularZaehlerFormular3;

        public static void allesAufAnfangBeiDenRegEx()
        { 
        
        }
                
        public static void InitNral()
        {
            fnral = new ReguläreAusdrücke();
            
            // Folgende Objekte werden bei Programmstart initialisiert.

            fnral.Add(new RegulärerAusdruck("E-Mail-Adressen auslesen.", @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b",
                "Dieser reguläre Ausdruck für das Auffinden von E-Mail-Adressen ist voreingestellt. Wenn Sie E-Mails mit einem anderen regulären Ausdruck filtern möchten, können Sie das Feld ändern. Beispielsweise können Sie an dieser Stelle vorgeben, dass nur E-Mail-Adressen mit bestimmten Endungen (.de, .com etc) berücksichtigt werden. Groß- & Kleinschreibung wird ignoriert.","","" ));

            fnral.Add(new RegulärerAusdruck("Namenskürzel auslesen.", @"\b[A-Z]{1,3}\b", @"Dieser reguläre Ausdruck durchsucht Ihren Serienbrief nach Namenskürzeln. Es wird angenommen, dass gesuchte Kürzel ein- bis dreistellig sind. Groß- & Kleinbuchstaben werden unterschieden. Wenn Coelina ein entsprechendes Kürzel in der PDF-Datei einem Kürzel in der Alias-Liste zuordnen kann, erfolgt der Versand an die zugeordnete E-Mail-Adresse. In der Voreinstellung werden Namenskürzel nur dann ausgewertet, sofern sie hinter dem Wort 'Verteiler:' stehen. Konsultieren Sie das Handbuch für Details.", "Verteiler:", ""));

            fnral.Add(new RegulärerAusdruck("Namen auslesen.", @"([A-Z][a-z]+) ([A-Z][a-z]+)", @"Dieser Reguläre Ausdruck durchsucht Ihre PDF-Datei nach Vor- und Nachnamen. Es wird angenommen, dass Namen aus Vor- und Nachnamen bestehen. ", "", ""));

            fnral.Add(new RegulärerAusdruck("Telefonnummern auslesen.", @"([0-9]+) ([0-9]+)", @"Dieser reguläre Ausdruck durchsucht Ihren Serienbrief nach einer Telefonnummer. Es wird angenommen, " +
                "dass die Telefonnummer nach DIN 5008 formatiert ist. So sehen din-gerechte Telefonnummern beispielsweise aus: 02861 9099-0 oder 030 4711 oder +49 2861 9099-0." +
                "Die Verwendung von Schrägstrichen oder Klammern ist nicht dingerecht.", "", ""));

            // Her[Rr]\s\S+?[\s|\p{P}] Herr Vöcking

            fnral.Add(new RegulärerAusdruck("Alias2 auslesen", @"(Herr\\.? |Mr\\.? |Dr.\\? |Prof.\\.? )", @"Herr", "", ""));

            fnral.Add(new RegulärerAusdruck("Z. Hd. auslesen.", @"\bHerr\b.*\bMeyer\b", @"Herr Meyer", "", ""));

            fnral.Add(new RegulärerAusdruck("Alias4 auslesen.", Properties.Settings.Default.RegExDefinition6, Properties.Settings.Default.RegExBeschreibung6, "", ""));

        }

        //public static void InitNral()
        //{
        //    fnral = new ReguläreAusdrücke();

        //    // Folgende Objekte werden bei Programmstart initialisiert.

        //    fnral.Add(new RegulärerAusdruck("E-Mail-Adressen auslesen.", @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b",
        //        "Dieser reguläre Ausdruck für das Auffinden von E-Mail-Adressen ist voreingestellt." +
        //        "Wenn Sie E-Mails mit einem anderen regulären Ausdruck filtern möchten, können Sie das Feld ändern.", "", ""));

        //    fnral.Add(new RegulärerAusdruck("Kürzel auslesen.", Properties.Settings.Default.RegExDefinition1, Properties.Settings.Default.RegExBeschreibung1, Properties.Settings.Default.RegExBegrenzer1_1, Properties.Settings.Default.RegExBegrenzer2_1));

        //    fnral.Add(new RegulärerAusdruck("Namen auslesen.", Properties.Settings.Default.RegExDefinition2, Properties.Settings.Default.RegExBeschreibung2, Properties.Settings.Default.RegExBegrenzer1_2, Properties.Settings.Default.RegExBegrenzer2_2));

        //    fnral.Add(new RegulärerAusdruck("Alias1 auslesen.", Properties.Settings.Default.RegExDefinition3, Properties.Settings.Default.RegExBeschreibung3, Properties.Settings.Default.RegExBegrenzer1_3, Properties.Settings.Default.RegExBegrenzer2_3));

        //    fnral.Add(new RegulärerAusdruck("Alias2 auslesen", Properties.Settings.Default.RegExDefinition4, Properties.Settings.Default.RegExBeschreibung4, Properties.Settings.Default.RegExBegrenzer1_4, Properties.Settings.Default.RegExBegrenzer2_4));

        //    fnral.Add(new RegulärerAusdruck("Alias3 auslesen.", Properties.Settings.Default.RegExDefinition5, Properties.Settings.Default.RegExBeschreibung5, Properties.Settings.Default.RegExBegrenzer1_5, Properties.Settings.Default.RegExBegrenzer2_5));

        //    fnral.Add(new RegulärerAusdruck("Alias4 auslesen.", Properties.Settings.Default.RegExDefinition6, Properties.Settings.Default.RegExBeschreibung6, Properties.Settings.Default.RegExBegrenzer1_6, Properties.Settings.Default.RegExBegrenzer2_6));

        //}
    }

    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {                       
            Global.InitNral();
            Global.InitNachrichten();
            Global.InitAlias();
            Global.InitLog();
            Global.fFormularZaehlerFormular1 = 0;
            Global.fFormularZaehlerFormular3 = 0;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMDI());
        }
    }
}
