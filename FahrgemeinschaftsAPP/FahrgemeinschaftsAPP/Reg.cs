using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Reg
    {
        /// <summary>
        /// User registers | Ceation of Username & Password | Saves Login Credentials in "Log.csv"
        /// </summary>
        public void Registration()
        {
            Console.Title = "CarpoolApp | Registration";
            Console.Clear();
            if (!File.Exists("C:\\Projects\\FahrgemeinschaftsAPP\\bin\\Log.csv"))
            {
                FileStream newFile = new FileStream("C:\\Projects\\FahrgemeinschaftsAPP\\bin\\Log.csv", FileMode.Create);
                newFile.Close();
            }

        RegLoop:
            
            //Überprüfen ob der Benutzername aus buchstaben besteht
            Regex regex = new Regex(@"[a-zA-Z]");
            string usrUserName;
            do
            {
                Console.WriteLine("Please register!");
                Console.Clear();
                Console.WriteLine("What do you want your username to be?: ");
                Console.Write("> ");
                var UserInputName = Console.ReadLine();
                if (regex.IsMatch(UserInputName))
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
                File.AppendAllText("C:\\Projects\\FahrgemeinschaftsAPP\\bin\\Log.csv", $"{usrUserName};{usrPassword}\n");
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
