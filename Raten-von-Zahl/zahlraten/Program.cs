using System;

namespace zahlraten
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zufall = new Random();
            int zufallszahl = zufall.Next(1, 101);
            int anz_versuche = 0;
            int alte_differenz = 100;
            int neue_differenz;
            int zahl;

            Console.WriteLine("Rate meine Zahl, die zwischen 1 und 100 liegt.");
            Console.WriteLine("");
            Console.WriteLine("Der Abstand zur Zahl wird zuerst mit 100 angenommen");

            do
            {
                Console.Write("Bitte gebe deine Zahl ein: ");
                zahl = Convert.ToInt32(Console.ReadLine());
                neue_differenz = Math.Abs(zufallszahl - zahl);
                if (neue_differenz < alte_differenz)
                {
                    if(neue_differenz > 0)
                    {
                        Console.WriteLine("...wärmer -> Du hast dich der Zahl genähert!");
                    }
                }
                else
                {
                    if (neue_differenz > alte_differenz)
                    {
                        Console.WriteLine("...kälter -> Du hast dich von der Zahl entfernt!");
                    }
                    else
                    {
                        Console.WriteLine("...unverändert -> Dein Abstand zur Zahl ist gleich!");
                    }
                }
                anz_versuche++;
                alte_differenz = neue_differenz;
                
            } while (zufallszahl != zahl);

            Console.WriteLine("Glückwunsch");
            Console.WriteLine("");
            Console.WriteLine("Du hast {0} Versuch(e) benötigt!", anz_versuche);
        }
    }
}
