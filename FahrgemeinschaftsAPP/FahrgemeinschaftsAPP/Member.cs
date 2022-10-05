using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Member
    {
        string memberPath = "C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv";
        List<string> Members;
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
                    Console.Title = $"FahrgemeinschaftsApp | Adding Member {i + 1}/{MA}";
                    Console.Clear();
                    Console.WriteLine("Gebe deinen Vollständigen Namen an: ");
                    Console.Write("> "); string VN = Console.ReadLine();
                    Console.WriteLine("Gebe deine Zeit für Arbeitsbeginn an: ");
                    Console.Write("> "); string TN = Console.ReadLine();
                    Console.WriteLine("Gebe deinen Wohnort an: ");
                    Console.Write("> "); string WN = Console.ReadLine();
                    Console.Clear();
                    var test = $"{VN};{TN};{WN}\n";
                    File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv", test, Encoding.UTF8);
                    Console.WriteLine($"Member {VN} added sunccesfully. ");
                    Thread.Sleep(2000);                   
                }                        
                Console.Title = $"FahrgemeinschaftsApp";                
                break;
            } while (true);

            //FileStream fs = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Users.csv", FileMode.Open);

        }
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
                            Console.WriteLine($"Vollständiger Name: {test[i]}");
                            break;
                        case 1:
                            Console.WriteLine($"Arbeitsbeginn: {test[i]}");
                            break;
                        case 2:
                            Console.WriteLine($"Wohn/Start Or: {test[i]}");
                            break;
                    }
                }
            }

        }
    }
}
