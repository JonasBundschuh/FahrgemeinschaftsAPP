using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Fahrgemeinschaften
    {
        public void Fahrgemeinschaft()
        {
            //Benutzer gibt an ob er die Fahrgemeinschaft als Fahrer(Driver) oder Mitfahrer(Member) erstellen will
            Console.Clear();
            Console.WriteLine("Do you want to add the Car Pool as Driver or Member?: ");
            string UserRole = Console.ReadLine();
            //Benutzer gibt die Anzahl der zu hinzuzufügenden Fahrgemeinschaften an
            Console.Clear();
            Console.WriteLine("How many Car Pools would you like to add?: ");
            int CPcount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < CPcount; i++)
            {
                int id = i;
                //Informationsabfrage wenn Fahrer ausgewählt wurde
                if (UserRole == "driver" || UserRole == "Driver")
                {

                    Console.Clear();
                    Console.WriteLine("How many seats does your car have?: ");
                    int FreeSeats = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Do you smoke?: ");
                    string Smoker = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is your name?");
                    string fullname = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is your starting location?: ");
                    string StartLoc = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is your ending location?: ");
                    string EndLoc = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("When do you start driving?: ");
                    string TimeStart = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"When do you want to be in {EndLoc}? ");
                    string TimeEnd = Console.ReadLine();
                    Console.Clear();
                    File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahgemeinschaft{i}.csv", $"{id};{FreeSeats};{Smoker};{fullname};{StartLoc};{EndLoc};{TimeStart};{TimeEnd}\n");
                }
                //Informationsabfrage wenn Mitfahrer ausgewählt wurde
                else if (UserRole == "Member" || UserRole == "member")
                {
                    Console.WriteLine("Do you smoke?; ");
                    string MembSmoker = Console.ReadLine();
                    Console.Clear();
                    File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahgemeinschaft{i}.csv", $"{id};{MembSmoker}\n");
                }
            }
            //Bestätigung
            Console.Clear();
            Console.WriteLine("Fahrgemeinschaften erfolgreich hinzugefügt!");
        }
        public void DisplayCarpools()
        {
        CrapoolDisplay:
            ConsoleKeyInfo BackToHome;
            int BTH = 0;
            Console.Title = $"FahrgemeinschaftsApp | Displaying CarPools";
            var fragmichnichtList = new List<string>();
            do
            {
                Console.Clear();

                foreach (string file in Directory.EnumerateFiles("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften", "*.csv"))
                {
                    
                    string content = File.ReadAllText(file);
                    fragmichnichtList.Add(content);                 
                    foreach (string cp in fragmichnichtList)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        var test = cp.Split(';');
                        for (int i = 0; i < test.Length; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine($"ID: {test[i]}");
                                    break;
                                case 1:
                                    Console.WriteLine($"Free Seats: {test[i]}");
                                    break;
                                case 2:
                                    Console.WriteLine($"Smoker: {test[i]}");
                                    break;
                                case 3:
                                    Console.WriteLine($"Name: {test[i]}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Drives from: {test[i]}");
                                    break;
                                case 5:
                                    Console.WriteLine($"Drives to: {test[i]}");
                                    break;
                                case 6:
                                    Console.WriteLine($"Starts at:  {test[i]}");
                                    break;
                                case 7:
                                    Console.WriteLine($"plans on arriving at: {test[i]}");
                                    break;


                            }
                        }
                    }
                }
                Console.WriteLine("[4] back to Menu");
                Console.Write("> ");
                BackToHome = Console.ReadKey();
                if (char.IsDigit(BackToHome.KeyChar))
                {
                    BTH = int.Parse(BackToHome.KeyChar.ToString());

                }
                if (BTH == 4)
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{BTH} is not a option. ");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto CrapoolDisplay;
                }
                
            } while (true);

        }
    }
}
