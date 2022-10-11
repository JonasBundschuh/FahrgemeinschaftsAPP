using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Program
    {

        static void Main(string[] args)
        {
            

            var CCollor = ConsoleColor.Yellow;
            Console.Title = "CarpoolApp by Jonas";

        Beginning:
            int UI = 0;
            ConsoleKeyInfo userChoice;
            do
            {
                //choice between regiserting and login
                Console.Clear();
                Console.WriteLine("Please choose a option: ");
                Console.WriteLine("------------------------");
                Console.ForegroundColor = CCollor;
                Console.WriteLine("[1] Login ");
                Console.WriteLine("[2] Register ");
                Console.WriteLine("[3] Exit");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("------------------------");
                Console.Write("> ");
                userChoice = Console.ReadKey();

                if (char.IsDigit(userChoice.KeyChar))
                {
                    
                    
                    UI = int.Parse(userChoice.KeyChar.ToString());
                    break;

                }

            } while (true);
            if (!File.Exists("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Register first!");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                var RegFirst = new Reg();
                RegFirst.Registration();
            }

            //if user choose login (1)
            if (UI == 1)
            {

                //login
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter your Username: ");
                Console.ForegroundColor = ConsoleColor.White;

                //benutzernamen überprüfen
                Console.Write("> "); string usrName = Console.ReadLine();
                if (CheckifUserNameExistD(usrName))
                {
                    //Password überprüfen
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter your Password: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("> "); string usrPass = Console.ReadLine();
                    if (CheckifUserPassExistD(usrPass))
                    {


                        //Willkommens screen + optionen
                        int USC1 = 0;
                        ConsoleKeyInfo userInputChoice;
                    home:
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("    ###       ###  ##########   ###         ########   ##########    ###     ###   ########## ");
                            Thread.Sleep(20);
                            Console.WriteLine("   ###       ###  ###          ###         ###        ###    ###   ####   #####   ###         ");
                            Thread.Sleep(20);
                            Console.WriteLine("  ##   ##   ##   ###          ###         ###        ###    ###   ### #  #  ###  ###          ");
                            Thread.Sleep(20);
                            Console.WriteLine(" ###  ###  ###  ########     ###         ###        ###    ###   ###  ###  ###  ########      ");
                            Thread.Sleep(20);
                            Console.WriteLine("###  #### ###  ###          ###         ###        ###    ###   ###       ###  ###            ");
                            Thread.Sleep(20);
                            Console.WriteLine("##### #####   ###          ###         ###        ###    ###   ###       ###  ###             ");
                            Thread.Sleep(20);
                            Console.WriteLine("###   ###    ##########   ##########  ########   ##########   ###       ###  ##########       ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");
                            Thread.Sleep(20);
                            Console.WriteLine($"                            Welcome {usrName}!");
                            Thread.Sleep(20);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("[1] Add Driver");
                            Thread.Sleep(20);
                            Console.WriteLine("[2] Add Member");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(20);
                            Console.WriteLine("[3] Display Divers");
                            Thread.Sleep(20);
                            Console.WriteLine("[4] Display Members");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(20);
                            Console.WriteLine("[5] Add Carpool");
                            Thread.Sleep(20);
                            Console.WriteLine("[6] Display Carpools");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(20);
                            Console.WriteLine("[7] Settings");
                            Thread.Sleep(20);
                            Console.WriteLine("[8] Logout");
                            Thread.Sleep(20);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("> ");
                            userInputChoice = Console.ReadKey();
                            if (char.IsDigit(userInputChoice.KeyChar))
                            {
                                USC1 = int.Parse(userInputChoice.KeyChar.ToString());
                                break;
                            }
                        } while (true);
                        //Opionen auswählen                     
                        if (USC1 == 1)
                        {
                            var drive = new Driver();
                            drive.AddDrivers();
                            goto home;
                        }
                        else if (USC1 == 2)
                        {
                            Member newMember = new Member();
                            newMember.AddMembere();
                            Thread.Sleep(2000);
                            goto home;
                        }
                        else if (USC1 == 3)
                        {
                            Console.Clear();
                            Driver SD = new Driver();
                            SD.DisplayDriver();
                            goto home;
                        }
                        else if (USC1 == 4)
                        {
                            var dm = new Member();
                            int USB = 0;
                            ConsoleKeyInfo userBack;
                            do
                            {
                                dm.DisplayMembers();
                                Console.WriteLine(" ");
                                Console.Clear();
                                Console.WriteLine("[1] Back home");
                                Console.Write("> "); userBack = Console.ReadKey();
                                if (USB == 1)
                                {
                                    goto home;
                                }
                                if (char.IsDigit(userBack.KeyChar))
                                {
                                    USB = int.Parse(userBack.KeyChar.ToString());
                                    break;

                                }
                            } while (true);

                        }
                        else if (USC1 == 5)
                        {
                            var FG = new Fahrgemeinschaften();
                            FG.Fahrgemeinschaft();
                            Thread.Sleep(2000);
                            Console.Clear();
                            goto home;
                        }
                        else if (USC1 == 6)
                        {
                            Fahrgemeinschaften DisplayCarP = new Fahrgemeinschaften();
                            DisplayCarP.DisplayCarpools();
                            goto home;
                        }
                        else if (USC1 == 7)
                        {
                            var s = new Settings();
                            s.SettingsDisplay();
                            goto home;
                        }
                        else if (USC1 == 8)
                        {
                            Console.Clear();
                            goto Beginning;
                        }
                        else if (USC1 == 9)
                        {
                            Fahrgemeinschaften DelCarpool = new Fahrgemeinschaften();
                            DelCarpool.Fahrgemeinschaft();
                            Thread.Sleep(2000);
                            goto home;
                        }
                        else
                        {
                            Console.WriteLine("invalid input, please try again!");
                            Thread.Sleep(2000);
                            goto home;
                        }
                    }
                    //überprüfen ob das password mit einem space anfängt/endet oder daraus besteht
                    else if (string.IsNullOrWhiteSpace(usrPass))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Password can not start/end with a space");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Beginning;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Password or username, please try again.");
                    }
                }
                //überprüfen ob der benutzername mit einem space anfängt/endet oder daraus besteht
                else if (string.IsNullOrWhiteSpace(usrName))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password can not start/end with a space");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Beginning;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Password or username, please try again.");
                }
            }
            //Benutzer wählt option 2 (Registrierung)
            else if (UI == 2)
            {
                var bar = new Reg();
                bar.Registration();
                Console.WriteLine("Registered successfully, you can now login.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                goto Beginning;
            }
            //Bentuter wählt option 3 (Beenden)
            else if (UI == 3)
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1500);
                Environment.Exit(1);
            }
            //Falsche eingabe detecten
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{UI} is not an option.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                goto Beginning;
            }
            Console.ReadLine();
        }
        //CSV datei nach benutzernamen durchsuchen
        private static bool CheckifUserNameExistD(string usrName)
        {
           
            string[] readText3 = File.ReadAllLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", Encoding.UTF8);
            List<string> readList3 = readText3.ToList();
            var filteredUsername = readText3.FirstOrDefault(x => x.Split(';').First() == usrName);
            if (filteredUsername != null)
            {
                return true;
            }
            return false;
        }

        //CSV datei nach password durchsuchen
        private static bool CheckifUserPassExistD(string usrPassword)
        {
            string[] readText3 = File.ReadAllLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", Encoding.UTF8);
            List<string> readList3 = readText3.ToList();
            var filteredPassword = readText3.FirstOrDefault(x => x.Split(';').Last() == usrPassword);
            if (filteredPassword != null)
                return true;
            return false;
        }
    }
}
