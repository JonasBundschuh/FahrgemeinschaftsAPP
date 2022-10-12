using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    /// <summary>
    /// Class to manage Members
    /// </summary>
    public class Member
    {
        string memberPath = "C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv";
        List<string> Members;
        /// <summary>
        /// Mitfahrer Hinzufügen
        /// </summary>
        public void AddMembere()
        {
            Console.Clear();
            if (!File.Exists(memberPath))
            {
                FileStream newFile = new FileStream(memberPath, FileMode.Create);
                newFile.Close();
            }
            else
            {
                Members = File.ReadLines(memberPath).ToList();
            }
            int MA = 0;
            ConsoleKeyInfo memberAnzahl;
            do
            {
                Console.Clear();
                Console.WriteLine("How many members would you like to add?");
                memberAnzahl = Console.ReadKey();
                if (char.IsDigit(memberAnzahl.KeyChar))
                {
                    MA = int.Parse(memberAnzahl.KeyChar.ToString());
                    //break;
                }            
                for (int i = 0; i < MA; i++)
                {
                    Console.Title = $"CarpoolApp | Adding Member {i + 1}/{MA}";
                    Console.Clear();
                    Console.WriteLine("Please enter your full name: ");
                    Console.Write("> "); string VN = Console.ReadLine();
                    Console.WriteLine("When do you start working: ");
                    Console.Write("> "); string TN = Console.ReadLine();
                    Console.WriteLine("Where do you live: ");
                    Console.Write("> "); string WN = Console.ReadLine();
                    Console.Clear();
                    var test = $"{VN};{TN};{WN}\n";
                    File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv", test, Encoding.UTF8);
                    Console.WriteLine($"Member {VN} added sunccesfully. ");
                    Thread.Sleep(2000);                   
                }                        
                Console.Title = $"CarpoolApp";                
                break;
            } while (true);

            //FileStream fs = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Users.csv", FileMode.Open);

        }
        /// <summary>
        /// Fahrer hinzufügen
        /// </summary>
        public void DisplayMembers()
        {
            List<string> lines = System.IO.File.ReadLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv").ToList();
            Console.Clear();
            foreach (string members in lines)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                var test = members.Split(';');
                for (int i = 0; i < test.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine($"Full Name: {test[i]}");
                            break;
                        case 1:
                            Console.WriteLine($"Starting to work at (time): {test[i]}");
                            break;
                        case 2:
                            Console.WriteLine($"Living at: {test[i]}");
                            break;
                    }
                }
            }

        }
    }
}
