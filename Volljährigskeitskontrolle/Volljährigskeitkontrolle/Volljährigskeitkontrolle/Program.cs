using System;

namespace Volljährigskeitkontrolle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programm: Volljährigkeitskontrolle";
            Console.WriteLine("\x1B[4mProgramm: Volljährigkeitskontrolle\x1B[0m");
            Console.WriteLine("");
            Console.Write("Geben sie ihr Alter in einer Ganzahl ein: ");

            if (Convert.ToInt16(Console.ReadLine()) >= 18){
                Console.WriteLine("Sie sind Volljährig");
            }else{
                Console.WriteLine("Sie sind nicht Volljährig");
            }
            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum Schließen drücken!");

            Console.ReadKey();
        }
    }
}
