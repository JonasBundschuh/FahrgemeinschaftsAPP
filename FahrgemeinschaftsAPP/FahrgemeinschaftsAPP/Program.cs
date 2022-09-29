using System;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Fahrgemeinschaft";






        Beginning:

            //Wahl zwischen login und registrieren
            Console.WriteLine("Please choose a option: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1] = Login ");
            Console.WriteLine("[2] = Register ");
            Console.ForegroundColor = ConsoleColor.White;
            int userChoice = Convert.ToInt32(Console.ReadLine());


            //LOGIN
            if (userChoice == 1)
            {
                string username = "root";
                string password = "root";

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter your Username: ");
                Console.ForegroundColor = ConsoleColor.White;

                //benutzernamen überprüfen
                string usrName = Console.ReadLine();
                if (usrName == username)
                {
                    //Password überprüfen
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter your Password: : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string usrPass = Console.ReadLine();
                    if (usrPass == password)
                    {

                    //Willkommens screen + optionen
                    home:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    ###       ###   ##########  ###        ########   ##########    ###     ###   ########## ");
                        Console.WriteLine("   ###       ###   ###         ###        ###        ###    ###   ####   #####   ###        ");
                        Console.WriteLine("  ##   ##   ##    ###         ###        ###        ###    ###   ### #  #  ###  ###                         ");
                        Console.WriteLine(" ###  ###  ###  ########     ###        ###        ###    ###   ###  ###  ###  ########     ");
                        Console.WriteLine("###  #### ###  ###          ###        ###        ###    ###   ###       ###  ###           ");
                        Console.WriteLine("##### #####  ###          ###         ###        ###    ###   ###       ###  ###            ");
                        Console.WriteLine("###   ###   ##########   ##########  ########   ##########   ###       ###  ##########      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"                            Welcome {username}!");

                        Console.WriteLine("[1] Add Driver");
                        Console.WriteLine("[2] Add Member");
                        Console.WriteLine("[3] Setings");
                        Console.WriteLine("[4] Logout");
                        Console.WriteLine(" ");
                        int UC = Convert.ToInt32(Console.ReadLine());

                        //Opionen auswählen
                        if (UC == 1)
                        {

                            var foo = new Driver();
                            foo.AddDrivers();
                            goto home;


                        }
                        else if(UC == 2)
                        {
                            var bar = new Member();
                            bar.AddMembere();
                            goto home;
                        }
                        else if (UC == 3)
                        {
                            var s = new Settings();
                            s.SettingsDisplay();

                        }else if(UC == 4)
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
                        goto Beginning;
                        

                    }
                }

                


            }
            else if(userChoice == 2)
            {
                var bar = new Reg();
                bar.Registration();
                goto Beginning;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{userChoice} ist keine option.");
                Thread.Sleep(1000);
                goto Beginning;
            }

            Console.ReadLine();
        }
    }
}
