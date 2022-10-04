using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FahrgemeinschaftsAPP
{
    public class Member
    {
        string memberPath = "C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv";
        List<string> Members;
        public Member()
        {
            Members = File.ReadLines(memberPath).ToList();
        }



        public void AddMembere()
        {
            Console.Clear();
            if (!File.Exists(memberPath))
            {
                FileStream newFile = new FileStream(memberPath, FileMode.Create);
                newFile.Close();
            }


            //FileStream fs = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Users.csv", FileMode.Open);
            int memberAnzahl = 1;
            for (int i = 0; i < memberAnzahl; i++)
            {
                Console.WriteLine("Gebe deinen Vollständigen Namen an: ");
                Console.Write("> "); string VN = Console.ReadLine();
                Console.WriteLine("Gebe deine Zeit für Arbeitsbeginn an: ");
                Console.Write("> "); string TN = Console.ReadLine();
                Console.WriteLine("Gebe deinen Wohnort an: ");
                Console.Write("> "); string WN = Console.ReadLine();
                byte[] bdata = Encoding.Default.GetBytes($"{VN}:{TN}:{WN}");
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv", $"{VN}:{TN}:{WN}\n");



            }
            List<string> lines = System.IO.File.ReadLines("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv").ToList();
        }
        public void DisplayMembers()
        {
            Console.Clear();
            foreach (string line in Members)
            {
                Console.WriteLine(line);
            }

        }
    }
}
