using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Reg
    {
        public void Registration()
        {
            Console.Title = "CarpoolApp | Registration";
            Console.Clear();
            if (!File.Exists("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv"))
            {
                FileStream newFile = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", FileMode.Create);
                newFile.Close();
            }

        RegLoop:

            Regex regex = new Regex(@"[a-zA-Z]");
            string usrUserName;
            do
            {
                Console.WriteLine("Please register!");
                Console.Clear();
                Console.WriteLine("What do you want your username to be?: ");
                Console.Write("> ");
                var UserInputName = Console.ReadLine();
                if (UserInputName == regex.ToString())
                {
                    usrUserName = (UserInputName.ToString());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"please only enter letters!");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto RegLoop;
                }
            } while (true);


            if (usrUserName.StartsWith(" ") || usrUserName.EndsWith(" "))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username can not start/end with a space");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto RegLoop;
            }


            Console.WriteLine("enter you password: ");
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

            Console.WriteLine("please repeat your password: ");
            Console.Write("> "); string usrPasswordconf = Console.ReadLine();
            if (usrPasswordconf == usrPassword)
            {
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", $"{usrUserName};{usrPassword}\n");
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
