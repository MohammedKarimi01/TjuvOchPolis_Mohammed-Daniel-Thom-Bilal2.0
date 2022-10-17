using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis_Mohammed_Daniel_Thom_Bilal
{
    internal class Civilian : Persons
    {
        public class Inventory : Civilian
        {
            public class Position : Civilian
            {
                Random random = new Random();
                string[,] position = new string[25, 101];

                int XAxel = random.next(0,26);
                int YAxel = random.next(0,101);
                string Civilian = "M";
            }
            public list<String> Belongings = new list<String>();
            public inventory()
            {
                Belongings.Add("Klocka");
                Belongings.add("Plånbok");
                Belongings.add("Pengar");
                Belongings.add("Mobil");
            }
        }
    }
}
