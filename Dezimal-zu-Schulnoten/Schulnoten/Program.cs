using System;

namespace Schulnoten
{
    class Program
    {
        static void Main(string[] args)
        {
            int ganzzahlnote;
            Console.Title = "Programm: Notenausgabe";
            Console.WriteLine("\x1B[4mProgramm: Notenausgabe\x1B[0m");
            Console.WriteLine("");

            Console.Write("Bitte Ganzzahlnote eingeben: ");
            ganzzahlnote = Convert.ToInt32(Console.ReadLine());

            switch (ganzzahlnote)
            {
                case 1: Console.WriteLine("Sehr gut"); break;
                case 2: Console.WriteLine("Gut"); break;
                case 3: Console.WriteLine("Befriedigend"); break;
                case 4: Console.WriteLine("Ausreichend"); break;
                case 5: Console.WriteLine("Mangelhaft"); break;
                case 6: Console.WriteLine("Ungenügend"); break;
                default: Console.WriteLine("Falsche Eingabe"); break;
            }

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum schließen drücken!");
            Console.ReadKey();

        }
    }
}
