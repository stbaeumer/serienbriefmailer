using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Coelina
{
    public class AliasListe:List<Alias>
    {
        
        public string AliasSuchenUndTextErsetzen(string pMailAdresse, string pText, string pAlias)
        {
            // Nur wenn mindestens 1x die folgende if-Kontrollstruktur durchlaufen wurde, werden Alias ersetzt.

            int zaehler = 0;

            int n = 0;
            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    zaehler++;        
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }

            // Der Alias wird ersetzt, sofern er vorhanden ist.

            if (pText.Contains(pAlias) && zaehler > 0)
            {
                
                //todo: Hier muss mit PropertyInfo propertyinfo ... der Quelltext noch verschönert werden.

                if (pAlias=="[Email]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Email);    
                }
                if (pAlias == "[Name]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Name);
                }
                if (pAlias == "[Kürzel]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Kürzel);
                }
                if (pAlias == "[Alias1]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Alias1);
                }
                if (pAlias == "[Alias2]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Alias2);
                }
                if (pAlias == "[Alias3]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Alias3);
                }
                if (pAlias == "[Alias4]")
                {
                    pText = pText.Replace(pAlias, Global.AliasMail[n].Alias4);
                }
            }

            // Der veränderte Text wird zurückgegeben.

            return pText;
        }

        public string AliasKürzelErmitteln(string pMailAdresse)
        {
            // Index ermitteln

            int n = 0;
            int z = 0;

            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item) gesetzt wird, soll der Wert zurückgegeben werden.
                    z++;
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }
            if (z==0)
            {
                // Wenn kein Kürzel existiert, dann werden zwei Leerzeichen zurückgegeben
                return "  ";
            }
            else
            {
                return Global.AliasMail[n].Kürzel;
            }
            
        }
        
        public string AliasNameErmitteln(string pMailAdresse)
        {
            // Index ermitteln

            int n = 0;
            int z = 0;
            
            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                    z++;
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }
            if (z == 0)
            {
                // Wenn kein Kürzel existiert, dann werden zwei Leerzeichen zurückgegeben
                return "  ";
            }
            else
            {
                return Global.AliasMail[n].Name;
            }
        }
        
        public string Alias1Ermitteln(string pMailAdresse)
        {
            // Index ermitteln

            int n = 0;
            int z = 0;

            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                    z++;
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }
            if (z == 0)
            {
                // Wenn kein Kürzel existiert, dann werden zwei Leerzeichen zurückgegeben
                return "";
            }
            else
            {
                return Global.AliasMail[n].Alias1;
            }
        }

        public string Alias2Ermitteln(string pMailAdresse)
        {
            // Index ermitteln

            int n = 0;
            int z = 0;

            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                    z++;
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }
            if (z == 0)
            {
                // Wenn kein Kürzel existiert, dann werden zwei Leerzeichen zurückgegeben
                return "  ";
            }
            else
            {
                return Global.AliasMail[n].Alias2;
            }
        }

        public string Alias3Ermitteln(string pMailAdresse)
        {
            // Index ermitteln

            int n = 0;
            int z = 0;

            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                    z++;
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }
            if (z == 0)
            {
                return "  ";
            }
            else
            {
                return Global.AliasMail[n].Alias3;
            }
        }
        
        public string Alias4Ermitteln(string pMailAdresse)
        {
            // Index ermitteln

            int n = 0;
            int z = 0;

            foreach (Alias item in this)
            {
                if (item.Email.ToLower() == pMailAdresse.ToLower())
                {
                    // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                    z++;
                    n = Global.AliasMail.IndexOf(item);
                    break;
                }
            }
            if (z == 0)
            {
                // Wenn kein Kürzel existiert, dann werden zwei Leerzeichen zurückgegeben
                return "  ";
            }
            else
            {
                return Global.AliasMail[n].Alias4;
            }
        }

        //internal string ermittleEmailAdresseAusEinemAlias(string p1, int p2, Func<Alias, string> func)
        //{
        //    throw new NotImplementedException();
        //}

        public string ermittleEmailAdresseAusEinemAlias(string pAlias, int pSpaltenIndex) 
        {
            
            int n = 0;
            int z = 0;

            foreach (Alias item in this)
            {
                if (pSpaltenIndex == 1) // Kürzel
                {
                    if (item.Kürzel == pAlias)
                    {
                        // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                        z++;
                        n = Global.AliasMail.IndexOf(item);
                        break;
                    }
                }

                if (pSpaltenIndex == 2)
                {
                    if (item.Name == pAlias) // Name
                    {
                        // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                        z++;
                        n = Global.AliasMail.IndexOf(item);
                        break;
                    }
                }

                if (pSpaltenIndex == 3)
                {
                    if (item.Alias1 == pAlias) // Alias1
                    {
                        // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                        z++;
                        n = Global.AliasMail.IndexOf(item);
                        break;
                    }
                }

                if (pSpaltenIndex == 4)
                {
                    if (item.Alias2 == pAlias)
                    {
                        // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                        z++;
                        n = Global.AliasMail.IndexOf(item);
                        break;
                    }
                }

                if (pSpaltenIndex == 5)
                {
                    if (item.Alias3 == pAlias)
                    {
                        // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                        z++;
                        n = Global.AliasMail.IndexOf(item);
                        break;
                    }
                }

                if (pSpaltenIndex == 6)
                {
                    if (item.Alias4 == pAlias) // Alias1
                    {
                        // Nur wenn der Wert von n tatsächlich durch Global.AliasMail.IndexOf(item); gesetzt wird, soll der Wert zurückgegeben werden.
                        z++;
                        n = Global.AliasMail.IndexOf(item);
                        break;
                    }
                }
            }

            if (z == 0)
            {
                // Wenn kein Kürzel existiert, dann werden zwei Leerzeichen zurückgegeben
                return "  ";
            }
            else
            {
                return Global.AliasMail[n].Email;
            }
        }
    }
}
