using System;

namespace Tasks_for_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\x1B[4mProgramm: Counter\x1B[0m");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(Convert.ToInt32(i) + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\x1B[4mProgramm: Addition ungerader Stellen einer Zahl\x1B[0m");
            int Summe = 0;

            Console.Write("Gib eine Nummer ein: ");
            int Eingabe = Convert.ToInt32(Console.ReadLine());
            int[] Zahlen = int[10];
            for (int i = 1; i <= Eingabe; i += 2)
            {
                Summe = Summe + i;
                Zahlen[i] = i;
            }
            Console.WriteLine(Zahlen);
            Console.WriteLine("Die Summe aller ungeraden Nummern von 1 bis {0} ist: {1}", Eingabe, Summe);
            Console.WriteLine("");
            Console.WriteLine("\x1B[4mProgramm: Zinseszins\x1B[0m");


            Console.Write("Gib dein Startgehalt ein: ");
            double Startguthaben = Convert.ToDouble(Console.ReadLine());
            int jahre = 0;
            
            for (int i = 0; i <= 12; i++)
            {
                Startguthaben = Startguthaben + Startguthaben * 0.05;
            }
            Console.WriteLine("Das Guthaben nach 12 Jahren ist: {0} Euro", Math.Round(Startguthaben, 2));

            Console.Write("Gib dein Startgehalt ein: ");
            Startguthaben = Convert.ToDouble(Console.ReadLine());

            double Kontrollvaribale = Startguthaben * 2;
            for (int i = 0; Startguthaben <= Kontrollvaribale; i++)
            {
                Startguthaben = Startguthaben + Startguthaben * 0.05;
                jahre++;
            }

            Console.WriteLine("Nach {0} Jahren hat sich der Kontostand verdoppelt", jahre);

            Console.ReadKey();
        }
    }
}
