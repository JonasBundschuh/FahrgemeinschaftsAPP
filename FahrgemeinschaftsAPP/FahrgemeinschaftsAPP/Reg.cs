using System;
using System.IO;
using System.Text;
using System.Threading;

namespace FahrgemeinschaftsAPP
{
    public class Reg
    {
            public void Registration()
            {
                Console.Clear();
                if (!File.Exists("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv"))
                {
                    FileStream newFile = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", FileMode.Create);
                    newFile.Close();
                }

            RegLoop:
                //FileStream fs = new FileStream("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Users.csv", FileMode.Open);
                Console.WriteLine("Was soll dein Benutzername sein?: ");
                string usrUsername = Console.ReadLine();


                Console.WriteLine("gebe dein password ein: ");
                string usrPassword = Console.ReadLine();
                Console.WriteLine("Bitte wiederhole dein password: ");
                string usrPasswordconf = Console.ReadLine();
            if (usrPasswordconf == usrPassword)
            {
                byte[] bdata = Encoding.Default.GetBytes($"{usrUsername}:{usrPassword}");
                //fs.Write(bdata, 0, bdata.Length);
                Console.Clear();
                File.AppendAllText("C:\\Projetcs\\FahrgemeinschaftsAPP\\bin\\Log.csv", $"{usrUsername};{usrPassword}\n");
                Console.WriteLine("Erfolgreich registriert, du kannst dich jetzt einloggen.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Passwords must match!!");
                goto RegLoop;
            }

            Console.ReadLine();
                

            }

        
    }
}
