﻿using System;
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
                            Console.WriteLine("[1] Add Driver");
                            Thread.Sleep(20);
                            Console.WriteLine("[2] Add Member");
                            Console.WriteLine(" ");
                            Thread.Sleep(20);
                            Console.WriteLine("[3] Display Divers");
                            Thread.Sleep(20);
                            Console.WriteLine("[4] Display Members");
                            Console.WriteLine(" ");
                            Thread.Sleep(20);
                            Console.WriteLine("[5] Add Carpool");
                            Console.WriteLine(" ");
                            Thread.Sleep(20);
                            Console.WriteLine("[6] Settings");
                            Thread.Sleep(20);
                            Console.WriteLine("[7] Logout");
                            Thread.Sleep(20);
                            Console.WriteLine(" ");
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
                            dm.DisplayMembers();
                            Console.WriteLine(" ");
                            Console.WriteLine("[1] Back home");
                            Console.Write("> "); int userBack = Convert.ToInt32(Console.ReadLine());
                            if (userBack == 1)
                            {
                                goto home;
                            }
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
                            var s = new Settings();
                            s.SettingsDisplay();
                            goto home;
                        }
                        else if (USC1 == 7)
                        {
                            Console.Clear();
                            goto Beginning;
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
                Console.WriteLine("Erfolgreich registriert, du kannst dich jetzt einloggen.");
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
                Console.WriteLine($"{UI} ist keine option.");
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
        public void Home()
        {

        }
    }
}
