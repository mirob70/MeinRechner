﻿using System;
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

         //  Wandel Text in Ganzzahlen
         int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
         int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

         // Berechnung ausführen
         int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

         //Ausgabe
         Console.WriteLine("Die summe ist: {0}", summe);

         Console.ReadLine();
      }
   }
}
