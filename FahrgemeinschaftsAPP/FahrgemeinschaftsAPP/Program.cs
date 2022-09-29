using System;
using System.Collections.Generic;

namespace FahrgemeinschaftsAPP
{
    internal class Program
    {



        static void Main(string[] args)
        {

            //Wahl zwischen login und registrieren
            Console.WriteLine("Please choose a option: ");
            Console.ForegroundColor = ConsoleColor.Red;
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter your Username: ");
                Console.ForegroundColor = ConsoleColor.White;

                //benutzernamen überprüfen
                string usrName = Console.ReadLine();
                if (usrName == username)
                {
                    //Password überprüfen
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter your Password: : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string usrPass = Console.ReadLine();
                    if (usrPass == password)
                    {

                        //Willkommens screen + optionen
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("    :::       ::: :::::::::: :::        ::::::::   ::::::::    :::   :::   ::::::::::");
                        Console.WriteLine("   :+:       :+: :+:        :+:       :+:    :+: :+:    :+:  :+:+: :+:+:  :+:        ");
                        Console.WriteLine("  +:+ +:+ +:+ +:+ +:+ +:+ +:+ +:+ +:+:+ +:+ +:+                                      ");
                        Console.WriteLine(" +#+  +:+  +#+ +#++:++#   +#+       +#+        +#+    +:+ +#+  +:+  +#+ +#++:++#     ");
                        Console.WriteLine("+#+ +#+#+ +#+ +#+        +#+       +#+        +#+    +#+ +#+       +#+ +#+           ");
                        Console.WriteLine("#+#+# #+#+#  #+#        #+#       #+#    #+# #+#    #+# #+#       #+# #+#            ");
                        Console.WriteLine("###   ###   ########## ########## ########   ########  ###       ### ##########      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"                            Welcome {username}!");

                        Console.WriteLine("[1] Add Driver");
                        int UC = Convert.ToInt32(Console.ReadLine());

                        //Opionen auswählen
                        if (UC == 1)
                        {
                            Console.Clear();

                            //Liste der fahrer
                            List<Drivers> drivers = new List<Drivers>();


                            //Hinzugefügten Fahrer ausgeben
                            
                        }

                        



















                    }
                }
                else
                {
                    Console.WriteLine("Wrong password or username please try again! ");
                }
            }

            Console.ReadLine();


        }
    }
}
