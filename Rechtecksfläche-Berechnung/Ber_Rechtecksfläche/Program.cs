using System;

namespace Ber_Rechtecksfläche
{
    class Program
    {
        static void Main(string[] args)
        {
            double laenge;
            double hoehe;
            double Flaecheninhalt;

            Console.Title = "Berechnung Rechtecksfläche";

            Console.WriteLine("\x1B[4mProgramm: Berechnung Rechtecksfläche\x1B[0m");
            Console.WriteLine("");

            Console.Write("Bitte geben Sie die Länge des Rechtecks ein und bestätigen sie mit Enter: ");
            laenge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Höhe des Rechtecks ein und bestätigen sie mit Enter: ");
            hoehe = Convert.ToDouble(Console.ReadLine());

            Flaecheninhalt = laenge * hoehe;

            Console.WriteLine("Die Rechtecksfläche beträgt " + Flaecheninhalt + " FE.");

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum Schließen drücken!");

            Console.ReadKey();
        }
    }
}
