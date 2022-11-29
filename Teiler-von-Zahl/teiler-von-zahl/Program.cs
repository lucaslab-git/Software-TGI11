using System;

namespace teiler_von_zahl
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            string check;
            int zw_teiler;
            int anz_teiler = 1;
            do
            {
                anz_teiler = 1;
                Console.WriteLine("Ausgabe der Teiler einer Zahl");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.Write("Bitte ganze Zahl, die größer als 0 ist eingeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < zahl; i++)
                {
                    
                    if(zahl % i == 0)
                    {
                        zw_teiler = zahl / i;
                        Console.WriteLine("Der {0}. Teiler ist: {1}", anz_teiler, zw_teiler);
                        anz_teiler++;
                    }
                }
                Console.WriteLine("Der {0}. Teiler ist: 1", anz_teiler);

                if (anz_teiler == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Primzahl!");
                }
                Console.WriteLine("");
                Console.Write("Soll das Programm wiederholt werden j für ja, n für nein: ");
                check = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");

            } while (check == "j");
            Console.WriteLine("");
            Console.WriteLine("Danke, dass sie das Programm benutzt haben.");
        }
    }
}
