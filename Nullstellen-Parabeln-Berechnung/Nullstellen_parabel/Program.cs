using System;

namespace Nullstellen_parabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programm: Nullstellen";
            Console.WriteLine("\x1B[4mProgramm: Nullstellen\x1B[0m");
            Console.WriteLine("");

            Console.Write("Bitte a eingeben: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte b eingeben: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte c eingeben: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double diskrimi = Math.Pow(b, 2) - 4 * a * c;

            double xValue = 0;
            double x2Value = 0;

            if (diskrimi > 0)
            {
                xValue = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                x2Value = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("Parabel hat zwei Punkte X1: " + xValue +" X2: " + x2Value);

            }
            else if (diskrimi == 0)
            {
                xValue = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                Console.WriteLine("Parabel hat einen Punkt X: " + xValue);
            }
            else
            {
                Console.WriteLine("Parabel hat keine Punkte");
            }

            Console.WriteLine("");
            Console.WriteLine("Bitte Enter zum schließen drücken!");
            Console.ReadKey();
        }

    }
}

