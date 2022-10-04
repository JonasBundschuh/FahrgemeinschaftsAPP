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
            Console.Title = "FahrgemeinschaftsApp by Jonas";

        Beginning:
            int UI = 0;
            ConsoleKeyInfo userChoice;
            do
            {
                //choice between regiserting and login
                Console.Clear();
                Console.WriteLine("Please choose a option: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ");
                Console.WriteLine("[1] Login ");
                Console.WriteLine("[2] Register ");
                Console.WriteLine("[3] Exit");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");

                Console.WriteLine($"");
                Console.Write("> ");
                userChoice = Console.ReadKey();

                if (char.IsDigit(userChoice.KeyChar))
                {
                    UI = int.Parse(userChoice.KeyChar.ToString());
                    break;

                }

            } while (true);

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
                    home:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    ###       ###  ##########   ###        ########   ##########    ###     ###   ########## ");
                        Console.WriteLine("   ###       ###  ###          ###         ###        ###    ###   ####   #####   ###         ");
                        Console.WriteLine("  ##   ##   ##   ###          ###         ###        ###    ###   ### #  #  ###  ###          ");
                        Console.WriteLine(" ###  ###  ###  ########     ###         ###        ###    ###   ###  ###  ###  ########      ");
                        Console.WriteLine("###  #### ###  ###          ###         ###        ###    ###   ###       ###  ###            ");
                        Console.WriteLine("##### #####   ###          ###         ###        ###    ###   ###       ###  ###             ");
                        Console.WriteLine("###   ###    ##########   ##########  ########   ##########   ###       ###  ##########       ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"                            Welcome {usrName}!");
                        Console.WriteLine("[1] Add Driver");
                        Console.WriteLine("[2] Add Member");
                        Console.WriteLine("[3] Display Divers");
                        Console.WriteLine("[4] Display Members");

                        Console.WriteLine("[5] Settings");
                        Console.WriteLine("[6] Logout");
                        Console.WriteLine(" ");
                        Console.Write("> "); int userInputChoice = Convert.ToInt32(Console.ReadLine());

                        //Opionen auswählen                     
                        if (userInputChoice == 1)
                        {

                            var drive = new Driver();
                            drive.AddDrivers();
                            goto home;

                        }
                        else if (userInputChoice == 2)
                        {
                            Member newMember = new Member();
                            newMember.AddMembere(); //wtf?

                            goto home;
                        }
                        else if (userInputChoice == 3)
                        {

                        }
                        else if (userInputChoice == 4)
                        {
                            var dm = new Member();
                            dm.DisplayMembers();
                            Console.WriteLine(" ");
                            Console.WriteLine("[1] Back home");
                            Console.Write("> "); int userBack = Convert.ToInt32(Console.ReadLine());   
                            if (userBack == 1)
                            {
                                goto home; 
                            }
                        }
                        else if (userInputChoice == 5)
                        {
                            var s = new Settings();
                            s.SettingsDisplay();
                        }
                        else if (userInputChoice == 6)
                        {
                            Console.Clear();
                            goto Beginning;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Falscher Benutzername oder Password, bitte erneut versuchen.");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Beginning;
                    }
                }
            }
            else if (UI == 2)
            {
                var bar = new Reg();
                bar.Registration();
                Console.WriteLine("Erfolgreich registriert, du kannst dich jetzt einloggen.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                goto Beginning;
            }
            else if (UI == 3)
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1500);
                System.Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{UI} ist keine option.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                goto Beginning;
            }
            Console.ReadLine();
        }
        private static bool CheckifUserNameExistD(string usrName)
        {
            string[] readText3 = File.ReadAllLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", Encoding.UTF8);
            List<string> readList3 = readText3.ToList();
            var filteredUsername = readText3.First(x => x.Split(';').First() == usrName);
            if (filteredUsername != null)
                return true;
            return false;
        }
        private static bool CheckifUserPassExistD(string usrPassword)
        {
            string[] readText3 = File.ReadAllLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", Encoding.UTF8);
            List<string> readList3 = readText3.ToList();
            var filteredPassword = readText3.First(x => x.Split(';').Last() == usrPassword);
            if (filteredPassword != null)
                return true;
            return false;
        }
    }
}
