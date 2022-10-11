using System;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Settings : Program
    {
        
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
        public void DisplayColors()
        {
            Console.WriteLine("[1] Red");
            Console.WriteLine("[2] Blue");
            Console.WriteLine("[3] Green");
            Console.WriteLine("[4] Yellow");
            Console.WriteLine("[5] Cyan");
            Console.WriteLine("[6] Magenta");
        }
    }
}
