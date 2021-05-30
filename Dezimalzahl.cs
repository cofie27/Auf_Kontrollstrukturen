
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmen
{
    class Dezimalzahl
    {
        //Deklaration und Kapselung des Attributs
        private double wert;

        //Standardkonstruktor
        public Dezimalzahl()
        {
            wert = 1.0;
        }

        //Eingabemethode für wert
        public void Eingabe()
        {
            //Eingabeaufforderung
            Console.Write("Bitte eine Dezimalzahl eingeben: ");
            wert = Convert.ToDouble(Console.ReadLine());
            while (wert < 0)
            {
                Console.WriteLine("Bitte eine positive Dezimalzahl eingeben: ");
                wert = Convert.ToDouble(Console.ReadLine());                                //Speichern der Benutzereingabe, wenn Eingabe > 0

            }
            
            //Speichern der Benutzereingabe
            
        }

        //Verschiedene Ausgabemethoden

        //Standardausgabe
        public void Ausgabe()
        {
            Console.WriteLine("Wert: {0}", wert);
        }

        //Ausgabe mit 15 Nachkommastellen
        public void Ausgabe15()
        {
            Console.WriteLine("Wert (mit 15 Nachkommastellen): {0:F15}", wert);
        }
        //Ausgabe in wissenchaftlicher Schreibweise
        public void AusgabeExp()
        {
            Console.WriteLine("Wert (exp.): {0:E10}", wert);
        }
        //Ausgabe im hexadezimalen System
        public void AusgabeHex()
        {
            Console.WriteLine("Wert (hex): {0:X}", Convert.ToInt64(wert));
        }
        //Ausgabe im oktalen System
        public void AusgabeOKT()
        {
            //Deklaration und Initialisierung von xDez/xOkt
            uint xDez = Convert.ToUInt32(wert);
            string xOkt = "";

            do                                                                         
            {
                string zwischenspeicher = Convert.ToString(xDez % 8);                           //privates Attrivut zwischenspeicher deklariert um den Rest dort zu speichern
                xOkt = zwischenspeicher + xOkt;                                                 //dem String xOkt wird ein Stelle hinzugefügt
                xDez = xDez / 8;                                                                //xDez wird durch 8 geteilt um den Wert oktal darstellen zu können

            } while (xDez >= 1);                                                                //solange xDez >=1, weil 0/8= 0 Rest 0 ->sonst endlos
            Console.WriteLine("Wert von (okt): " + xOkt);                                       //Ausgabe des Eingabewertes im oktalen System
                
        }
        //Ausgabe im binären System
        public void AusgabeBin()
        {
            //Deklaration und Initialisierung von xDez/xBin
            uint xDez = Convert.ToUInt32(wert);
            string xBin = "";

            do
            {
                if (xDez % 2 != 0)                                                              //wenn der Rest von xDez/2 ungelich 0 ist, dann....
                {
                    xBin = "1" + xBin;                                                          //Dem String xBin wird die "1" hinzugefügt
                }
                else
                {
                    xBin = "0" + xBin;                                                          //Dem String xBin wird die "0" hinzugefügt
                }
                xDez = xDez / 2;                                                                //xDez/2 da man so die Dezimalzahl binär darstellen kann

            } while (xDez >= 1);                                                                //solange xDez >=1, weil 0/2= 0 Rest 0 ->sonst endlos (Abbruchbedinung)
            Console.WriteLine("Wert (bin): " + xBin);                                           //Ausgabe des Eingabewertes im Binärsystem 

        }
        //Ausgabe ganzzahliger Quadratwuurzel (, falls vorhanden)
        public void AusgabeWurzel()
        {
            //Deklaration und Initialisierung von i
            uint i = 1;

            while (wert > i * i)                                                                //solange Eingabewert > i*i, dann... (Abbruchbedingung)
            {
                i++;                                                                            //i um 1 erhöhen
            }
            if (wert == i * i)                                                                  //wenn Eingabewert gleich i*i, dann...
            {
                Console.WriteLine("Die Quadratwurzel von " +wert +" ist: " + i);                //Ausgbae der ganzzahligen Quadratwurzel (wenn vorhanden), was in der if- Bedinung geprüft wird
            }
            else
            {
                Console.WriteLine("Error: keine ganzzahlige Quadratwurzel gefunden");           //andernfalls, also wenn i*i nie gleich dem Eingabewert wird, dann wird auf der Konsole ein Fehler ausgegeben
            }
                
        }
        // Ausgabe der Quadratwurzel durchs Heron-Verfahren
        public void AusgabeHeron()                                      
        {
            //Deklaration und Initialisierung von x und y
            float y = 1;                                                                        //als float, um die Dezimalstellen (hier:Nachkommastellen) zu begrenzen und keine Endlosschleife zu erhalten
            double x = wert;
            

            while (x>y)                                                                         //Abbruchbedingung
            {
                x = (x + y) / 2;                                                                //x wird gleich dem Ergebnis von (x+y)/2 gesetzt
                y = Convert.ToSingle(wert / x) ;                                                //
            }
            Console.WriteLine("Die Quadratwurzel  von {0} lt. Heronverfahren ist: {1:F5}",wert,x);  //Ausgabe der Quadratwurzel 
        }
        //Ausgabe des größten gemeinsamen Teilers, nach Eingabe von zwei Werten
        public void AusgabeGGT()
        {
            //Deklaration und Initialisierung von A, B, T und G
            uint A = 0;
            uint B = 0;
            double T = 2;
            double G = 1;

            Console.WriteLine("Bitte geben Sie zwei Werte ein um den gemeinsamen Teiler zu ermitteln (A/B): ");  //Eingabeaufforderung wird ausgegeben
            A = Convert.ToUInt16(Console.ReadLine());                                                            //Lesen der Eingabe in der ersten Zeile
            B = Convert.ToUInt16(Console.ReadLine());                                                            //Lesen der Eingabe in der zweiten Zeile
            do
            {
                if ((A % T == 0))                                                                                //wenn der Rest von A/T gleich null ist, dann...
                {
                    if (B % T== 0)                                                                               //wenn der Rest von A/B gleich null ist, dann...
                    {
                        G = T;                                                                                   //setze G gleich T
                    }
                }
                T++;                                                                                            //T um 1 erhöhen
            } while (T <= A && T <= B);                                                                         //Abbruchbedingung
            Console.WriteLine("Der größte gemeinsame Teiler von " + A + " und " + B + " ist: " + G);            //Ausgabe von G
        }

    }
}