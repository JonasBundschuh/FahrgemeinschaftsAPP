using System;
using System.IO;
using System.Text;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Driver
    {
        public void AddDrivers()
        {
            Console.Clear();
            //if (!File.Exists("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv"))
            //{
            //    FileStream newFile = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv", FileMode.Create);
            //    newFile.Close();
            //}


            //FileStream fs = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Users.csv", FileMode.Open);
            Console.WriteLine("Wie viele fahrer möchtest du hinzufügen");
            int fahrerAnzahl = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < fahrerAnzahl; i++)
            {
                Console.WriteLine("Gebe den vornamen des fahrers ein");
                string VN = Console.ReadLine();
                Console.WriteLine("Gebe den nachnamen des fahrers ein");
                string NN = Console.ReadLine();
                Console.WriteLine("Gebe die fahrzeit des fahrers ein");
                string TN = Console.ReadLine();
                byte[] bdata = Encoding.Default.GetBytes($"{VN}:{NN}:{TN}");
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Drivers.csv", $"{VN};{NN};{TN}\n");
                Console.WriteLine($"Fahrer {VN} {NN} erfolgreich hinzugefügt!");
                Thread.Sleep(2000);
                
                

            }
        }
    }
}
