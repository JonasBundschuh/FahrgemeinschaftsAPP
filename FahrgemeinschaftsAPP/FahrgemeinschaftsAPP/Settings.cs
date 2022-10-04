using System;
using System.IO;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Settings : Program
    {
        public void SettingsDisplay()
        {
            Settings:
            Console.Clear();
            Console.WriteLine("[1] Change Theme");
            Console.WriteLine("[2] Change Username");
            Console.WriteLine("[3] Change Password");
            Console.WriteLine(" ");
            Console.WriteLine("[4] Back to home");

            Console.Write("> "); int settingsChoice = Convert.ToInt32(Console.ReadLine());

            if (settingsChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
                goto Settings;
            }
            else if (settingsChoice == 2)
            {

                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
                goto Settings;
            }
            else if (settingsChoice == 3)
            {

                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
                goto Settings;
            }
            else if (settingsChoice == 4)
            {

                Console.Clear();
                Console.WriteLine("Coming soon.");
                Thread.Sleep(2000);
            }

        }
    }
}
