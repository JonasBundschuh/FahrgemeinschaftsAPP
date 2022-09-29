using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrgemeinschaftsAPP
{
    public class Settings : Program
    {
        public void SettingsDisplay()
        {
            Console.Clear();
            Console.WriteLine("[1] Change Theme");
            Console.WriteLine("[2] Change Username");
            Console.WriteLine("[3] Change Password");
            Console.WriteLine(" ");
            Console.WriteLine("[4] Back to home");

            int settingsChoice = Convert.ToInt32(Console.ReadLine());

        }
    }
}
