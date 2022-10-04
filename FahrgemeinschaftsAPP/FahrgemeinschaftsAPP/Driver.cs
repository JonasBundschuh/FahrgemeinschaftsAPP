using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Driver
    {
        public void AddDrivers()
        {
            int FA = 0;
            ConsoleKeyInfo fahrerAnzahl;
            do
            {
                Console.Clear();
                Console.WriteLine("Wie viele fahrer möchtest du hinzufügen");
                Console.Write("> ");
                fahrerAnzahl = Console.ReadKey();
                Console.Clear();
                if (char.IsDigit(fahrerAnzahl.KeyChar))
                {
                    FA = int.Parse(fahrerAnzahl.KeyChar.ToString());
                    break;
                }
            } while (true);
            for (int i = 0; i < FA; i++)
            {
                Console.WriteLine("Gebe den Vornamen des fahrers ein");
                Console.Write("> "); string VN = Console.ReadLine();
                Console.WriteLine("Gebe den Nachnamen des fahrers ein");
                Console.Write("> "); string NN = Console.ReadLine();
                Console.WriteLine("Gebe die Fahrzeit des Fahrers in Stunden ein");
                Console.Write("> "); string TN = Console.ReadLine();
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv", $"{VN};{NN};{TN}\n");
                Console.WriteLine($"Fahrer {VN} {NN} erfolgreich hinzugefügt!");
                Thread.Sleep(2000);
            }
        }

        List<string> Drivers;
        public void DisplayDriver()
        {

            Drivers = File.ReadLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv").ToList();
            foreach (string driver in Drivers)
            {
                Console.WriteLine(driver);
            }
            Console.WriteLine(" ");
            Console.WriteLine("[4] Back to home");
            int DPback = Convert.ToInt32(Console.ReadLine());
            if (DPback == 4)
            {

            }
            else
            {
                Console.WriteLine("test");
            }
        }

    }
}
