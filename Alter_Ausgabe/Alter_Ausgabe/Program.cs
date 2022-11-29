using System;

namespace Alter_Ausgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter; //Deklaration
            Console.Title = "Programm: Alter ausgeben";
            Console.WriteLine("\x1B[4mProgramm: Alter ausgeben\x1B[0m");
            Console.WriteLine("");
            Console.WriteLine("Bitte geben sie ihr Alter ein und bestätigen Sie mit Enter.");
            Console.WriteLine("");

            alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Sie sind \x1B[4m" + alter + "\x1B[0m Tomaten alt.");
            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum schließen drücken!");

            Console.ReadKey();
        }
    }
}
