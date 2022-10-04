using System;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Settings : Program
    {
        public void SettingsDisplay()
        {
        Settings:
            int SC = 0;
            ConsoleKeyInfo settingsChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Change Theme");
                Console.WriteLine("[2] Change Username");
                Console.WriteLine("[3] Change Password");
                Console.WriteLine(" ");
                Console.WriteLine("[4] Back to home");

                Console.Write("> ");
                settingsChoice = Console.ReadKey();

                if (char.IsDigit(settingsChoice.KeyChar))
                {
                    SC = int.Parse(settingsChoice.KeyChar.ToString());
                    break;
                }
            } while (true);


            if (SC == 1)
            {
                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
            }
            else if (SC == 2)
            {
                Console.Clear();
                Console.WriteLine("Coming soon.");
            }
            else if (SC == 3)
            {
                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
                goto Settings;
            }
            else if (SC == 4)
            {
                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a valid option, please try again.");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                goto Settings;
            }
        }
    }
}
