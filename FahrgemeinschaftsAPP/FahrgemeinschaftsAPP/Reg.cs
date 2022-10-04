using System;
using System.IO;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Reg
    {
        public void Registration()
        {
            Console.Clear();
            if (!File.Exists("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv"))
            {
                FileStream newFile = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", FileMode.Create);
                newFile.Close();
            }

        RegLoop:
            Console.WriteLine("Was soll dein Benutzername sein?: ");
            Console.Write("> "); string usrUsername = Console.ReadLine();
            bool invalidChar = usrUsername.Contains(" ");
            if (usrUsername.StartsWith(" ") || usrUsername.EndsWith(" "))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username can not start/end with a space");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto RegLoop;
            }


            Console.WriteLine("gebe dein password ein: ");
            Console.Write("> "); string usrPassword = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(usrPassword))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password can not start/end with a space");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto RegLoop;
            }

            Console.WriteLine("Bitte wiederhole dein password: ");
            Console.Write("> "); string usrPasswordconf = Console.ReadLine();
            if (usrPasswordconf == usrPassword)
            {
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", $"{usrUsername};{usrPassword}\n");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Passwords must match!!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto RegLoop;
            }


        }


    }
}
