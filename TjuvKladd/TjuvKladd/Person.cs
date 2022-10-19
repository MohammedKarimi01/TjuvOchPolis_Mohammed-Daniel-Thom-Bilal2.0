using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvKladd
{
    internal class Person
    {
        public int CordX { get; set; }
        public int CordY { get; set; }
        public string Inventory { get; set; }
        public int CordXdirection { get; set; }
        public int CordYdirection { get; set; }

        Random Random1 = new Random();
        int RandomX = Random1;

        Random Random2 = new Random();

        Person person = new Person();
        public Person(int cordX, int cordY, string inventory, int cordXdirection, int cordYdirection)
        {
            CordX = cordX;
            CordY = cordY;
            Inventory = inventory;
            CordXdirection = cordXdirection;
            CordYdirection = cordYdirection;
        }
    }
}
