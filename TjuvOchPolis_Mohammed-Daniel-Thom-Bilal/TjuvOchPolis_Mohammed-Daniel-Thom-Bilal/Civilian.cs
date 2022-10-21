using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis_Mohammed_Daniel_Thom_Bilal
{
    internal class Civilian : Persons
    {
        public void Items()
        {
            Random slump = new Random();
            int rnd = slump.Next(0, 4);
            string[] Items = { "mobil", "plånbok", "pengar", "klocka"};
            Console.WriteLine(Items[rnd]);


   
        }

        public string C { get; set;}
        public Civilian()
        {
            C = "C";
        }
        public void tagen()
        {
            int e;

        }

    }
}
