using System;

namespace Ber_Dreiecksfläche
{
    class Program
    {
        static void Main(string[] args)
        {
            double laenge;
            double hoehe;
            double Flaecheninhalt;

            Console.Title = "Berechnung Dreiecksfläche";

            Console.WriteLine("\x1B[4mProgramm: Berechnung Dreiecksfläche\x1B[0m");
            Console.WriteLine("");

            Console.Write("Bitte geben Sie die Länge der Grundseite des Dreiecks und bestätigen sie Enter: ");
            laenge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Höhe des Dreiecks ein und bestätigen sie Enter: ");
            hoehe = Convert.ToDouble(Console.ReadLine());

            Flaecheninhalt = 0.5 * laenge * hoehe;

            Console.WriteLine("Die Dreicksfläche beträgt " + Flaecheninhalt + " FE.");

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum Schließen drücken!");

            Console.ReadKey();
        }
    }
}
