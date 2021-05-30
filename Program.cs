//------------------------------------------------------------------------------------------------------------------------------------
//Dateiname	    : Auf_Kontrollstrukturen
//Projekt	    : Auf_Kontrollstrukturen
//Beschreibung  :
//Autoren	    : Paul Atuahene
//Erstellung	: 13.01.2021
//letzte Änd.	: 18.01.2021
//Fehler	    : 
//Dokument	    : auf_Kontrollstrukturen
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dezimalzahl d1 = new Dezimalzahl();             //Objekt "d1" der Klasse Dezimalahl erzeugt
            Dezimalzahl d2 = new Dezimalzahl();             //Objekt "d2" der Klasse Dezimalahl erzeugt
            Console.WriteLine("---------------------------Test1---------------------------");                                                           //Abgrenzung
            d1.Eingabe();                                   //Eingabeaufforderung wird ausgegeben 
            d1.Ausgabe();                                   //Ausgabe der Eingabe
            d1.Ausgabe15();                                 //Ausgabe der Eingabe mit 15 Nachkommastellen
            d1.AusgabeExp();                                //Ausgabe der Eingabe in wissenschaftlicher Schreibweise
            d1.AusgabeHex();                                //Ausgabe der Eingabe im hexadezimalen System
            d1.AusgabeBin();                                //Ausgabe der Eingabe im binären System
            d1.AusgabeOKT();                                //Ausgabe der Eingabe im oktalen System
            d1.AusgabeWurzel();                             //Ausgabe der ganzzahligen Quadratwurzel (falls vorhanden) der Eingabe    
            d1.AusgabeHeron();                              //Ausgabe der Quadratwurzel der Eingabe durch Heron-Verfahren

            Console.WriteLine("---------------------------Test2---------------------------");                                                           //Abgrenzung
            d2.Eingabe();                                   //Eingabeaufforderung wird ausgegeben
            d2.Ausgabe();                                   //Ausgabe der Eingabe
            d2.Ausgabe15();                                 //Ausgabe der Eingabe mit 15 Nachkommastellen
            d2.AusgabeExp();                                //Ausgabe der Eingabe in wissenschaftlicher Schreibweise
            d2.AusgabeHex();                                //Ausgabe der Eingabe im hexadezimalen System
            d2.AusgabeBin();                                //Ausgabe der Eingabe im binären System
            d2.AusgabeOKT();                                //Ausgabe der Eingabe im oktalen System
            d2.AusgabeWurzel();                             // Ausgabe der ganzzahligen Quadratwurzel(falls vorhanden) der Eingabe
            d2.AusgabeHeron();                              //Ausgabe der Quadratwurzel der Eingabe durch Heron-Verfahren
            d2.AusgabeGGT();                                //Ausgabe des größten gemeinsamen Teilers nach Eingabe von zwei Werten
            //d1.AusgabeGGT();                              //alternativ
            Console.WriteLine("Test erfolgreich durchgeführt");                                                                                         //Ausgabe, dass der Test eerfolgreich durchgeführt wurde

            /*
            //3 Dezimalzahlobjekte erzeugen
            Dezimalzahl anzahlAtiwSchueler = new Dezimalzahl();
            Dezimalzahl mittlereKlassenstaerke = new Dezimalzahl();
            Dezimalzahl preisMittagessen = new Dezimalzahl();

            //Werte einlesen
            Console.WriteLine("Anzahl der Schüler, die das ATIW besuchen: ");
            anzahlAtiwSchueler.EingabeWert();
            Console.WriteLine("Mittlere Klassenstärke der ATIW-Klassen: ");
            mittlereKlassenstaerke.EingabeWert();
            Console.WriteLine("Preis der letzten Mittagessens: ");
            preisMittagessen.EingabeWert();

            //Ausgabemethoden testen
            anzahlAtiwSchueler.AusgabeTest();
            mittlereKlassenstaerke.AusgabeTest();
            preisMittagessen.AusgabeTest();

            Console.ReadKey(); */
        }
    }
}
