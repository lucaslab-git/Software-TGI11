using System;

namespace Ber_Kreisfläche
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double durchmesser;
            double Flaecheninhalt;

            Console.Title = "Berechnung Kreisfläche";

            Console.WriteLine("\x1B[4mProgramm: Berechnung Kreisfläche\x1B[0m");
            Console.WriteLine("");

            Console.Write("Bitte geben Sie den Durchmesser des Kreises ein und bestätigen sie mit Enter: ");
            durchmesser = Convert.ToDouble(Console.ReadLine());

            radius = durchmesser / 2;
            Flaecheninhalt = Math.PI * radius * radius;

            Console.WriteLine("Die Kreisfläche beträgt " + Flaecheninhalt + " FE.");

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum Schließen drücken!");

            Console.ReadKey();
        }
    }
}
