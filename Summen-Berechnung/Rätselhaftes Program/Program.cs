using System;

namespace Rätselhaftes_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            int summe;

            Console.Title = "Rätselhaftes Program";

            Console.WriteLine("\x1B[4mRätselhaftes Programm: Zahlen addieren\x1B[0m");
            Console.WriteLine("");
            Console.Write("Bitte geben Sie die 1.Zahl und bestätigen sie Enter: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben Sie die 2.Zahl und bestätigen sie Enter: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            summe = zahl1 + zahl2;

            Console.WriteLine("Das Ergebnis ist: " + summe);

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum Schließen drücken!");

            Console.ReadKey();

        }
    }
}
