using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis_Mohammed_Daniel_Thom_Bilal
{
    internal class Persons
    {
        public int CordX{ get; set; }
        public int CordY { get; set; }
        public int Xdirection { get; set; }
        public int Ydirection { get; set; }
        public string inventory { get; set; }

        public Persons(int cordx, int cordy)
        {
            CordX = cordx;
            CordY = cordy;
        }

    }
}
