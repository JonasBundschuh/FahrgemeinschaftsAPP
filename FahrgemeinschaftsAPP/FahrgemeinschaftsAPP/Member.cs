using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrgemeinschaftsAPP
{
    public class Member : Gen
    {
        public void AddMembere()
        {
            Console.Clear();
            if (!File.Exists("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv"))
            {
                FileStream newFile = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv", FileMode.Create);
                newFile.Close();
            }


            //FileStream fs = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Users.csv", FileMode.Open);
            int memberAnzahl = 1;
            for (int i = 0; i < memberAnzahl; i++)
            {
                Console.WriteLine("Gebe deinen Vollständigen Namen an: ");
                string VN = Console.ReadLine();
                Console.WriteLine("Deine Zeit für Arbeitsbeginn an: ");
                string TN = Console.ReadLine();
                Console.WriteLine("Gebe deinen Wohnort an: ");
                string WN = Console.ReadLine();
                byte[] bdata = Encoding.Default.GetBytes($"{VN}:{TN}:{WN}");
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Members.csv", $"{VN}:{TN}:{WN}\n");

            }
        }
    }
}
