using System;

namespace Flächenberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            string auswahl;
            Console.Title = "Programm: Berechnung Flächen";
            Console.WriteLine("\x1B[4mProgramm: Berechnung Flächen\x1B[0m");
            Console.WriteLine("Was wollen sie berechnen?");
            Console.WriteLine("- Kreis <k>");
            Console.WriteLine("- Rechteck <r>");
            Console.WriteLine("- Dreieck <d>");
            Console.WriteLine("");
            Console.Write("Bitte k, d oder r eingeben:");

            auswahl = Console.ReadLine();

            if (auswahl == "k")
            {
                k();
            }
            else if (auswahl == "r")
            {
                r();
            }
            else if (auswahl == "d")
            {
                d();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("");
                Console.WriteLine("Bitte Enter zum Schließen drücken!");

                Console.ReadKey();
            }


        }
        static void k()
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
        static void d()
        {
            double laenge;
            double hoehe;
            double Flaecheninhalt;
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
        static void r()
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
