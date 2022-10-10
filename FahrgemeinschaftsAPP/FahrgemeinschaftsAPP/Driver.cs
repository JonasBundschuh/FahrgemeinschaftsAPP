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
                Console.Clear();
                Console.Title = $"FahrgemeinschaftsApp | Adding Carpool {i + 1}/{FA}";
                Console.WriteLine("Gebe den Vornamen des fahrers ein");
                Console.Write("> "); string VN = Console.ReadLine();
                Console.WriteLine("Gebe den Nachnamen des fahrers ein");
                Console.Write("> "); string NN = Console.ReadLine();
                Console.WriteLine("Gebe die Fahrzeit des Fahrers in Stunden ein");
                Console.Write("> "); string TN = Console.ReadLine();
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv", $"{VN};{NN};{TN}\n");
                Console.WriteLine($"Fahrer {VN} {NN} erfolgreich hinzugefügt!");
                Console.Title = $"FahrgemeinschaftsApp by Jonas";
                Thread.Sleep(2000);
            }
        }

        List<string> Drivers;
        public void DisplayDriver()
        {
        DisplayDrivers:
            Console.Clear();
            Console.Title = $"FahrgemeinschaftsApp | Displaying Drivers";
            Drivers = File.ReadLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv").ToList();

            foreach (string driver in Drivers)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                var test = driver.Split(';');
                for (int i = 0; i < test.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine($"Vorname: {test[i]}");
                            break;
                        case 1:
                            Console.WriteLine($"Nachname: {test[i]}");
                            break;
                        case 2:
                            Console.WriteLine($"Vorraussichtliche Fahrzeit in Stunden: {test[i]}");
                            break;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[4] Back to home");
            int DPB = 0;
            ConsoleKeyInfo dPBack;

            do
            {

                dPBack = Console.ReadKey();
                if (char.IsDigit(dPBack.KeyChar))
                {
                    DPB = int.Parse(dPBack.KeyChar.ToString());
                }
                if (DPB == 4)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Not a option. ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    goto DisplayDrivers;

                }

            } while (true);
        }

    }
}
