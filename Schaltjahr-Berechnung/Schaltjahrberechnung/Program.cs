using System;

namespace Schaltjahrberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            int jahr;
            bool ist_schaltjahr;
            Console.Title = "Programm: Schaltjahrsberechnung";
            Console.WriteLine("\x1B[4mProgramm: Schaltjahrsberechnung\x1B[0m");
            Console.WriteLine("");

            Console.Write("Bitte Jahr eingeben: ");
            jahr = Convert.ToInt32(Console.ReadLine());

            if(jahr % 4 == 0)
            {
                ist_schaltjahr = true;
                if(jahr % 100 == 0)
                {
                    if (jahr % 400 != 0)
                    {
                        ist_schaltjahr = false;
                    }
                    else
                    {
                        ist_schaltjahr = true;
                    }
                }
                else
                {
                    ist_schaltjahr = true;
                }
            }
            else
            {
                ist_schaltjahr = false;
            }

            if(ist_schaltjahr == true)
            {
                Console.WriteLine("Es " + jahr + " ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine("Es " + jahr + " ist kein Schaltjahr");
            }

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum schließen drücken!");
            Console.ReadKey();
        }
    }
}
