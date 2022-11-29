using System;

namespace Geradenberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            double m1;  //Geraden
            double m2;
            double y1;
            double y2;

            double sx; //Schnittpunkte
            double sy;

            Console.Title = "Programm: Geradenberechnung";
            Console.WriteLine("\x1B[4mProgramm: Geradenberechnung\x1B[0m");
            Console.WriteLine("");

            Console.Write("1. Gerade: Bitte Steigung eingeben: ");
            m1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("1. Gerade: Bitte y-Achsenabschitt eingeben: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Gerade: Bitte Steigung eingeben: ");
            m2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Gerade: Bitte y-Achsenabschitt eingeben: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIhre Geraden haben folgende Gleichungen:");
            Console.Write("1. Gerade: y = " + Convert.ToString(m1) + "x"); if (y1 >= 0) { Console.WriteLine("+" + Convert.ToString(y1)); } else { Console.WriteLine(Convert.ToString(y2)); }
            Console.Write("2. Gerade: y = " + Convert.ToString(m2) + "x"); if (y2 >= 0) { Console.WriteLine("+" + Convert.ToString(y2)); } else { Console.WriteLine(Convert.ToString(y2)); }
            Console.WriteLine("");

            if (m1 == m2 && y1 == y2)
            {
                Console.WriteLine("Die Geraden sind identisch"); 
            }
            else if(m1 == m2)
            {
                Console.WriteLine("Die Geraden sind parrallel");

            }
            else 
            {
                sx = (y1 - y2) / (m2 - m1);
                sy = m1 * sx + y1;

                Console.WriteLine("Die Geraden schneiden sich bei Punkt S(" + Convert.ToString(sx) + "|" + Convert.ToString(sy) + ")");
            }

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum schließen drücken!");
            Console.ReadKey();
        }
    }
}
