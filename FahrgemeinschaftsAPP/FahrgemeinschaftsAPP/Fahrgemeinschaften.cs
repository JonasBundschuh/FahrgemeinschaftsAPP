using System;
using System.IO;

namespace FahrgemeinschaftsAPP
{
    public class Fahrgemeinschaften
    {
        public void Fahrgemeinschaft()
        {
            //Benutzer gibt an ob er die Fahrgemeinschaft als Fahrer(Driver) oder Mitfahrer(Member) erstellen will
            Console.Clear();
            Console.WriteLine("Do you want to add the Car Pool as Driver or Member?: ");
            string UserRole = Console.ReadLine();
            //Benutzer gibt die Anzahl der zu hinzuzufügenden Fahrgemeinschaften an
            Console.Clear();
            Console.WriteLine("How many Car Pools would you like to add?: ");
            int FGcount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < FGcount; i++)
            {
                int id = i;
                //Informationsabfrage wenn Fahrer ausgewählt wurde
                if (UserRole == "driver" || UserRole == "Driver")
                {

                    Console.Clear();
                    Console.WriteLine("How many seats does your car have?: ");
                    int FreeSeats = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Do you smoke?: ");
                    string Smoker = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is your starting location?: ");
                    string StartLoc = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is your ending location?: ");
                    string EndLoc = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("When do you start driving?: ");
                    string TimeStart = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"When do you want to be in {EndLoc}? ");
                    string TimeEnd = Console.ReadLine();
                    Console.Clear();
                    File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahgemeinschaft{i}.csv", $"{id};{FreeSeats};{Smoker};{StartLoc};{EndLoc};{TimeStart};{TimeEnd}\n");
                }
                //Informationsabfrage wenn Mitfahrer ausgewählt wurde
                else if (UserRole == "Member" || UserRole == "member")
                {
                    Console.WriteLine("Do you smoke?; ");
                    string MembSmoker = Console.ReadLine();
                    Console.Clear();
                    File.AppendAllText($"C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Fahrgemeinschaften\\Fahgemeinschaft{i}.csv", $"{id};{MembSmoker}\n");
                }
            }
            //Bestätigung
            Console.Clear();
            Console.WriteLine("Fahrgemeinschaften erfolgreich hinzugefügt!");
        }
    }
}
