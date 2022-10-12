using System;
using System.IO;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Settings
    {
        /// <summary>
        /// Display Settings and Option
        /// </summary>
        public void SettingsDisplay()
        {
            Console.Title = "CarpoolApp | Settings";
        Settings:
            int SC = 0;
            ConsoleKeyInfo settingsChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Change Theme");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[2] Change Username");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[3] Change Password");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("[4] Back to home");
                Console.WriteLine(" ");

                Console.Write("> ");
                settingsChoice = Console.ReadKey();


                if (char.IsDigit(settingsChoice.KeyChar))
                {
                    SC = int.Parse(settingsChoice.KeyChar.ToString());

                }
                if (SC == 1)
                {
                    Console.Clear();
                    ChangeColor();
                }
                else if (SC == 2)
                {
                    Console.Clear();
                    ChangeUsername();
                }
                else if (SC == 3)
                {
                    ChangePass();
                    Console.WriteLine("Password changed successfully");
                    Thread.Sleep(1500);
                    goto Settings;
                }
                else if (SC == 4)
                {
                    Console.Clear();
                    return;
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
            } while (true);



        }
        /// <summary>
        /// Overwrite Color Variable
        /// </summary>
        public void ChangeColor()
        {
            int UCC = 0;
            ConsoleKeyInfo usrColorChoice;
            do
            {
                Console.Clear();
                DisplayColors();
                Console.WriteLine(" ");
                Console.WriteLine("Please choose one of the above listed colors: ");
                usrColorChoice = Console.ReadKey();

                if (char.IsDigit(usrColorChoice.KeyChar))
                {
                    UCC = int.Parse(usrColorChoice.KeyChar.ToString());
                    break;
                }

                switch (UCC)
                {
                    case 0:
                        var CColer = ConsoleColor.Red;
                        break;
                    case 1:
                        CColer = ConsoleColor.Blue;
                        break;
                    case 2:
                        CColer = ConsoleColor.Green;
                        break;
                    case 3:
                        CColer = ConsoleColor.Yellow;
                        break;
                    case 4:
                        CColer = ConsoleColor.Cyan;
                        break;
                    case 5:
                        CColer = ConsoleColor.DarkBlue;
                        break;
                    case 6:
                        CColer = ConsoleColor.Magenta;
                        break;
                    default:
                        CColer = ConsoleColor.White;
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// Display all colors the User can choose from
        /// </summary>
        public void DisplayColors()
        {
            Console.WriteLine("[1] Red");
            Console.WriteLine("[2] Blue");
            Console.WriteLine("[3] Green");
            Console.WriteLine("[4] Yellow");
            Console.WriteLine("[5] Cyan");
            Console.WriteLine("[6] Magenta");
        }
        /// <summary>
        /// Change Username of the registered User
        /// </summary>
        public void ChangeUsername()
        {
            Console.WriteLine("What would you like to change your Username to? ");
            string NewUsrName = Console.ReadLine();

            string oldPassWordIn = File.ReadAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv");
            string[] SplittedOldLog = oldPassWordIn.Split(';');
            string oldPass = SplittedOldLog[1];
            File.Delete("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv");
            File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", $"{NewUsrName};{oldPass}");
        }
        /// <summary>
        /// Change Password of the Registered User
        /// </summary>
        public void ChangePass()
        {
            Console.Clear();
            Console.WriteLine("What would you like to change your password to? ");
            string NewPass = Console.ReadLine();

            string oldUserNameIn = File.ReadAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv");
            string[] SplittedOldLog = oldUserNameIn.Split(';');
            string oldUser = SplittedOldLog[0];
            File.Delete("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv");
            File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", $"{oldUser};{NewPass}");
        }
    }
}
