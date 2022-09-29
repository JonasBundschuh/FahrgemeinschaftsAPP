using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrgemeinschaftsAPP
{
    public class Drivers
    {
        string VorName { get; set; }
        string NachName { get; set; }

        public Drivers(string vorName, string nachName)
        {
            NachName = nachName;
            VorName = vorName;
        }


    }
}
