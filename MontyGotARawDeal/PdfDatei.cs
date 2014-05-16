using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Coelina
{
    public class PdfDatei
    {
        private string fName;
        
        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }
        
        private string fVollständigerPfadZurDatei;

        public string VollständigerPfadZurDatei
        {
            get { return fVollständigerPfadZurDatei; }
            set { fVollständigerPfadZurDatei = value; }
        }
        
        private string fAktivesVerzeichnis;

        public string AktivesVerzeichnis
        {
            get { return fAktivesVerzeichnis; }
            set { fAktivesVerzeichnis = value; }
        }
        
        private string fZeitstempel;

        public string Zeitstempel
        {
            get { return fZeitstempel; }
            set { fZeitstempel = value; }
        }

        private string fUnterverzeichnis;

        public string Unterverzeichnis
        {
            get { return fUnterverzeichnis; }
            set { fUnterverzeichnis = value; }
        }

        public override string ToString()
        {
            string ausgabetext = "";

            return ausgabetext;
        }

        private string fEmail;

        public string Email
        {
            get { return fEmail; }
            set { fEmail = value; }
        }

        private int fAnzahlSeiten;

        public int AnzahlSeiten
        {
            get { return fAnzahlSeiten; }
            set { fAnzahlSeiten = value; }
        }

        public string neustePdfDateiAusgeben(string pAktivesVerzeichnis)
        {
            bool IsExists = System.IO.Directory.Exists(pAktivesVerzeichnis);

            // ein leerer oder falscher Pfad gibt null zurück.
            
            if (pAktivesVerzeichnis=="" || !IsExists)
            {
                return null;
            }
            else
            {
                DirectoryInfo verzeichnis = new DirectoryInfo(pAktivesVerzeichnis);
                FileInfo[] pdfDateien = verzeichnis.GetFiles("*.pdf");

                // Wenn das aktive Verzeichnis keine Dateien enthält, kommt eine Meldung.

                if (verzeichnis.GetFiles("*.pdf").Count() == 0)
                {
                    return "keine PDF-Datei in diesem Ordner";
                }
                
                DateTime dateiZeitstempel = new DateTime(0);
                FileInfo jüngstePdfDatei = null;

                foreach (FileInfo pdfDatei in pdfDateien)
                {
                    if (pdfDatei.LastWriteTime > dateiZeitstempel)
                    {
                        dateiZeitstempel = pdfDatei.LastWriteTime;
                        jüngstePdfDatei = pdfDatei;
                    }
                }

                StreamReader reader = jüngstePdfDatei.OpenText();
                string text = reader.ReadToEnd();
                this.Name = jüngstePdfDatei.FullName;
                this.VollständigerPfadZurDatei = System.IO.Path.Combine(pAktivesVerzeichnis, jüngstePdfDatei.FullName);
                           
                return this.VollständigerPfadZurDatei;       
            }
        }

        public string wähleAnhang(string initialDirectory, string bisherigeDatei)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF Dateien (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*";
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Wählen Sie eine Datei.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
            {
                return bisherigeDatei;
            }
        }

        public string wähleAktivesVerzeichnis(string initialDirectory)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Wählen Sie ein Verzeichnis.";
            objDialog.SelectedPath = this.AktivesVerzeichnis;

            // Nur wenn in dem FolderBrowserDialog tatsächlich mit OK ein Pfad gewählt wurde, geklickt wurde wird das bisherige Aktive Verzeichnis überschrieben.

            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                return objDialog.SelectedPath;
            }
            else
            {
                return this.AktivesVerzeichnis;
            }
        }
        
        public PdfDatei(string pAktivesVerzeichnis)
        {
            fAktivesVerzeichnis = pAktivesVerzeichnis;
        }

        public PdfDatei()
        {

        }

        public PdfDatei(string pAktivesVerzeichnis, string pEmail)
        {
            fAktivesVerzeichnis = pAktivesVerzeichnis;
            fEmail = pEmail;
        }

        public void zeitstempelSetzen()
        {
            this.fZeitstempel = string.Format("{0:yyyyMMdd-hh-mm-ss}", DateTime.Now.ToLocalTime());
        }

        public void erstelleOrdner()
        {
            this.zeitstempelSetzen();
            
            //Create a new subfolder under the current active folder

            this.Unterverzeichnis = System.IO.Path.Combine(System.IO.Path.GetTempPath(), Zeitstempel);
            
            
            // Create the subfolder
            System.IO.Directory.CreateDirectory(this.Unterverzeichnis);
        }

        public void erzeugeMailListe()
        {
            //MailListe neueMailliste = new MailListe();
        }

        public void zerlegePdfInEinzelseiten(string zuZerlegendeDatei)
        {
            try
            {
                FileInfo file = new FileInfo(zuZerlegendeDatei);
                string name = file.Name.Substring(0, file.Name.LastIndexOf("."));
                // we create a reader for a certain document
                PdfReader reader = new PdfReader(zuZerlegendeDatei);
                // we retrieve the total number of pages
                int n = reader.NumberOfPages;
                int digits = 1 + (n / 10);
                Document document;
                int pagenumber;
                string filename;

                for (int i = 0; i < n; i++)
                {   
                    pagenumber = i + 1;
                    filename = pagenumber.ToString();
                    while (filename.Length < digits) filename = "0" + filename;
                    filename = "_" + filename + ".pdf";
                    // step 1: creation of a document-object
                    document = new Document(reader.GetPageSizeWithRotation(pagenumber));
                    // step 2: we create a writer that listens to the document
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(this.Unterverzeichnis + "\\" + name + filename, FileMode.Create));
                    // step 3: we open the document
                    document.Open();
                    PdfContentByte cb = writer.DirectContent;
                    PdfImportedPage page = writer.GetImportedPage(reader, pagenumber);
                    int rotation = reader.GetPageRotation(pagenumber);
                    if (rotation == 90 || rotation == 270)
                    {
                        cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(pagenumber).Height);
                    }
                    else
                    {
                        cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                    }
                    // step 5: we close the document
                    document.Close();
                }
            }
            catch
            {
                //MessageBox.Show("Welche Datei solles sein?");
            }
        }

        // Es wird der gesuchte Ausdruck aus der PDF-Fatei ausgelesen.

        public List<string> ReadPdfFile(string fileName, string RegexPattern, string begrenzer1, string begrenzer2, int pComboBoxIndex)
        {
            StringBuilder text = new StringBuilder();

            PdfReader pdfReader = new PdfReader(fileName);

            // Jede einzelne Seite wird ausgelesen.
                
            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string derGesamteAusgeleseneTextInEinemString = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                if (begrenzer1 != "")
                {
                    // Überflüssiges vorne abschneiden

                    Regex regex = new Regex(begrenzer1);

                    string[] substrings = regex.Split(derGesamteAusgeleseneTextInEinemString);

                    derGesamteAusgeleseneTextInEinemString = substrings[1];
                }


                if (begrenzer2 != "")
                {
                    // Überflüssiges hinten abschneiden

                    Regex hinten = new Regex(begrenzer2);

                    string[] substrings = hinten.Split(derGesamteAusgeleseneTextInEinemString);

                    derGesamteAusgeleseneTextInEinemString = substrings[0];
                }
                
                derGesamteAusgeleseneTextInEinemString = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(derGesamteAusgeleseneTextInEinemString)));
                text.Append(derGesamteAusgeleseneTextInEinemString);
                
                pdfReader.Close();

                //MessageBox.Show(derGesamteAusgeleseneTextInEinemString);
            }
        
            // Auf jeder Seite können auch mehr als eine gefundene Adresse verarbeitet werden.


            System.Text.RegularExpressions.MatchCollection matches;


            // Bei der E-Mail-Adresse wird Groß-/Kleinschreibung nicht unterschieden. Beim Kürzel, Namen etc. schon.

            if (pComboBoxIndex == 0)
            {
                 matches = System.Text.RegularExpressions.Regex.Matches(text.ToString(), RegexPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            }
            else
            {
                 matches = System.Text.RegularExpressions.Regex.Matches(text.ToString(), RegexPattern);
            }
                     

            



            List<string> gefundeneReguläreAusdrücke = new List<string>();

            int zaehler = 0;

            string ausgabe = "";

            foreach (Match match in matches)
            {
                
                // Wenn in den Einstellungen festgelegt ist, dass eine bestimmte Domain ignoriert wird, wird ggfs. nichts zurückgegeben.

                if ((Properties.Settings.Default.DieseDomainIgnorieren != "" && match.Value.EndsWith(Properties.Settings.Default.DieseDomainIgnorieren)) || (Properties.Settings.Default.DieseMailIgnorieren != "" && match.Value == Properties.Settings.Default.DieseMailIgnorieren))
                {
                    gefundeneReguläreAusdrücke.Add("Die gefundene E-Mail-Adresse wird aufgrund Ihrer Einstellungen ignoriert.");
                    ausgabe = "\n" + ausgabe + "\n" + "Die gefundene E-Mail-Adresse wird aufgrund Ihrer Einstellungen ignoriert.";
                }
                else
                {
                    gefundeneReguläreAusdrücke.Add(match.Value.ToString());
                    ausgabe = "\n" + ausgabe + "\n" + match.Value.ToString();
                }
    
                zaehler++;
            }
            
            return gefundeneReguläreAusdrücke;    
        }

        public void umbenennen(string alterName, string neuerName)
        {
            try
            {
                File.Move(alterName, neuerName);
            }
            catch (Exception)
            {
                MessageBox.Show("Die Datei "+alterName+ " kann nicht nach "+neuerName+" umbenannt werden, da bereits eine Datei mit dem Namen existiert.");
            }   
        }
                
        public void zerlegteEinzelseitenUmbenennen(string DateiNameDerEinzelseiten, Document dokument)
        { 
        
        }


    }
}
