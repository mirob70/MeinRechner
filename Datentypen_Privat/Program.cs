using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen_Privat
{
   class Program
   {
      static void Main(string[] args)
      {
         float pi = 3.14f;
         Console.WriteLine("Unser Pi hat den Wert: {0}", pi);
         float pi2 = 0.0314e2f; // BSP2 :ist  0,0314 hoch2 also 0,0314*10 hoch2
         Console.WriteLine("Unser Pi hat den Wert: {0}", pi2);

         float max = float.MaxValue;
         Console.ReadLine();
      }
   }
}
