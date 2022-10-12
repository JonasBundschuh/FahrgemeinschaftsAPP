using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    /// <summary>
    /// dlfkgdlfkgmldf
    /// </summary>
    public class Fahrgemeinschaften
    {
        public int Id { set; get; }
        public string FreeSeats { set; get; }
        public string Smoke { set; get; }
        public string FullName { set; get; }
        public string StartLoc { set; get; }
        public string EndLoc { set; get; }
        public string TimeStart { set; get; }
        public string TimeEnd { set; get; }

        public Fahrgemeinschaften()
        {
            Id = 0;
            FreeSeats = "";
            Smoke = "";
            FullName = "";
            StartLoc = "";
            EndLoc = "";
            TimeStart = "";
            TimeEnd = "";
        }

        /// <summary>
        /// Fahrgemeinschaft/en hinzufügen
        /// </summary>
        public void Fahrgemeinschaft()
        {


            //Benutzer gibt an ob er die Fahrgemeinschaft als Fahrer(Driver) oder Mitfahrer(Member) erstellen will
            Console.Clear();

            //Benutzer gibt die Anzahl der zu hinzuzufügenden Fahrgemeinschaften an
            Console.Clear();
            Console.WriteLine("How many Car Pools would you like to add?: ");
            int CPcount = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            for (i = 0; i < CPcount; i++)
            {
                Console.Title = $"FahrgemeinschaftsApp | Adding Member {i + 1}/{CPcount}";
                //int it = 0; 
                Id = i;
                //Informationsabfrage wenn Fahrer ausgewählt wurde
                Console.Clear();
                Console.WriteLine("How many seats does your car have?: ");
                int FreeSeats = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Do you smoke?: ");
                string Smoke = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is your name?");
                string fullName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is your starting location?: ");
                string startLoc = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is your ending location?: ");
                string endLoc = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("When do you start driving?: ");
                string timeStart = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"When do you want to be in {endLoc}? ");
                string timeEnd = Console.ReadLine();
                Console.Clear();
                foreach (string file in Directory.EnumerateFiles("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften", "*.csv"))
                {
                    Id++;

                }
                File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahrgemeinschaft{i}.csv", $"{Id};{FreeSeats};{Smoke};{fullName};{startLoc};{endLoc};{timeStart};{timeEnd};\n");

            }
            //Bestätigung
            Console.Clear();
            Console.WriteLine("Carpools added successfully!");
        }

        /// <summary>
        /// Fahrgemeinschaften anzeigen
        /// </summary>
        public void DisplayCarpools()
        {
        CrapoolDisplay:
            ConsoleKeyInfo BackToHome;
            int BTH = 0;
            Console.Title = $"FahrgemeinschaftsApp | Displaying CarPools";

            do
            {
                Console.Clear();

                foreach (string file in Directory.EnumerateFiles("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften", "*.csv"))
                {

                    string content = File.ReadAllText(file);
                    var fragmichnichtList = new List<string>();
                    fragmichnichtList.Add(content);
                    foreach (string cp in fragmichnichtList)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        var comboToSplit = cp.Split(';');
                        for (int i = 0; i < comboToSplit.Length; i++)
                        {
                            switch (i)
                            {

                                case 0:
                                    Console.WriteLine($"ID: {comboToSplit[i]}");
                                    break;
                                case 1:
                                    Console.WriteLine($"Free Seats: {comboToSplit[i]}");
                                    break;
                                case 2:
                                    Console.WriteLine($"Smoker: {comboToSplit[i]}");
                                    break;
                                case 3:
                                    Console.WriteLine($"Name: {comboToSplit[i]}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Drives from: {comboToSplit[i]}");
                                    break;
                                case 5:
                                    Console.WriteLine($"Drives to: {comboToSplit[i]}");
                                    break;
                                case 6:
                                    Console.WriteLine($"Starts at:  {comboToSplit[i]}");
                                    break;
                                case 7:
                                    Console.WriteLine($"plans on arriving at: {comboToSplit[i]}");
                                    break;
                                case 8:
                                    Console.WriteLine($"Drives with: {comboToSplit[i]}");
                                    break;
                            }
                        }
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine("[4] back to Menu");
                Console.WriteLine("[5] join a Carpool");
                Console.WriteLine("[6] leave a Carpool");
                Console.WriteLine("[7] delete a Carpool");
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
                else if (BTH == 5)
                {

                    JoinCarpool();
                }
                else if (BTH == 6)
                {
                    LeaveCarpool();
                }
                else if (BTH == 7)
                {
                    DeleteCarpool();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"That is not a option. ");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto CrapoolDisplay;
                }

            } while (true);




            //int FreeSeats, string Smoker, string fullname, string StartLoc, string EndLoc, string TimeStart, string TimeEnd


        }

        /// <summary>
        /// Fahrgemeinschaft beitreten
        /// </summary>
        public void JoinCarpool()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to join any of the listed carpools? (y/n)");
            string userJoinCarPool = Console.ReadLine();
            Console.WriteLine("Under what name would you like to join the carpool?:");
            string joinAs = Console.ReadLine();
            if (userJoinCarPool == "y")
            {
                Console.WriteLine("What is the ID of the carpool you want to join?");
                int iDtoJoin = Convert.ToInt32(Console.ReadLine());
                File.Delete($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahrgemeinschaft{iDtoJoin}.csv");
                File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahrgemeinschaft{iDtoJoin}.csv", $"{Id};{FreeSeats};{Smoke};{FullName};{StartLoc};{EndLoc};{TimeEnd};{joinAs}");
                Console.Clear();
                DisplayCarpools();
            }
            else if (userJoinCarPool == "n")
            {
                DisplayCarpools();
            }
        }

        /// <summary>
        /// Fahrgemeinschaft verlassen
        /// </summary>
        public void LeaveCarpool()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to leave a carpool (y/n)?  ");
            string userLeaveCarpool = Console.ReadLine();
            if (userLeaveCarpool == "y")
            {
                Console.WriteLine("Please enter the ID of the Carpool you would like to leave: ");
                int idToLeave = Convert.ToInt32(Console.ReadLine());
                File.Delete($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahrgemeinschaft{idToLeave}.csv");
                File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahrgemeinschaft{idToLeave}.csv", $"{Id};{FreeSeats};{Smoke};{FullName};{StartLoc};{EndLoc};{TimeEnd}");
                Console.Clear();
                DisplayCarpools();
            }
            else if(userLeaveCarpool == "n")
            {
                Console.Clear();
                DisplayCarpools();
            }
            
        }

        /// <summary>
        /// Fahrgemeinschaft löschen
        /// </summary>
        public void DeleteCarpool()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to delete a Carpool? (y/n)");
            string usrDelCarpool = Console.ReadLine();
            if (usrDelCarpool == "y")
            {
                Console.WriteLine("What is the ID of the Carpool you want to delete: ");
                int IDtoDelete = Convert.ToInt32(Console.ReadLine());
                File.Delete($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahrgemeinschaft{IDtoDelete}.csv");
            }
            else if (usrDelCarpool == "n")
            {
                DisplayCarpools();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{usrDelCarpool} is not a valid option!");
                Thread.Sleep(2000);
                Console.ForegroundColor= ConsoleColor.White;    
            }
            
        }
    }
}
