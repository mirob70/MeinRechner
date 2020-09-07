using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinRechner
{
   class Program
   {
      static void Main(string[] args)
      {
       // User Story "Addieren": Als Benutzer möchte ich zwei zahlen eingeben, um deren Summe berechnen zu lassen
       Console.Write("Bitte gib den ersten Summanden ein: ");
         string ersterSummand = Console.ReadLine();

         Console.Write("Bitte gib den zweiten Summanden ein: ");
         string zweiterSummand = Console.ReadLine();

         //  Wandel Text in Gleitkommazahlen
         double ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
         double zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

         // Berechnung ausführen
         double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

         //Ausgabe
         Console.WriteLine("Die summe beträgt: {0}", summe);

         Console.ReadLine();
      }
   }
}
