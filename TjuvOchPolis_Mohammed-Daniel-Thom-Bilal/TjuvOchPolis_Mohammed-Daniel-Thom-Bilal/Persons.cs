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
        
        public Persons()
        {
            CordX = 0;
            CordY = 0;
            Random Random1 = new Random();
            CordX = Random1.Next(0,101);
            CordY = Random1.Next(0,26);
            CordX += Xdirection;
            CordY += Ydirection;
            
        }
        public int randomDirectionX(int random)
        {
            switch (random)
            {
                case 1:
                    Xdirection = 0;
                    CordX += Xdirection;
                    break;
                case 2:
                    Xdirection = 1;
                    CordX += Xdirection;
                    break;
                case 3:
                    Xdirection = -1;
                    CordX += Xdirection;
                    break;
            }
            if (CordX > 100)
            {
                CordX = 1;
            }
            if (CordX < 0)
            {
                CordX = 100;
            }
            return CordX;
        }
        public int randomDirectionY(int random)
        {
            switch (random)
            {
                case 1:
                    Ydirection = 0;
                    CordY += Ydirection;
                    break;
                case 2:
                    Ydirection = 1;
                    CordY += Ydirection;
                    break;
                case 3:
                    Ydirection = -1;
                    CordY += Ydirection;
                    break;
            }
            if (CordY > 100)
            {
                CordY = 1;
            }
            if (CordY < 0)
            {
                CordY = 100;
            }
            return CordY;
        }
        public void randomDirection()
        {

        }
        //public void print(List<Persons> persons)
        //{
        //    for (int i = 0; i < 30; i++)
        //    {
        //        persons.Add(new Persons());
        //    }
        //    foreach (Persons person1 in persons)
        //    {
        //        Console.WriteLine(person1.CordX + " " + person1.CordY);
        //        if (person1 is Police)
        //        {
        //            for (int i = 0; i < 10; i++)
        //            {
        //                Console.WriteLine("P" + i);
        //            }
        //        }
        //        if (person1 is Thief)
        //        {
        //            for (int i = 0; i < 10; i++)
        //            {
        //                Console.WriteLine("P" + i);
        //            }
        //        }
        //        if (person1 is Civilian)
        //        {
        //            for (int i = 0; i < 10; i++)
        //            {
        //                Console.WriteLine("P" + i);
        //            }
        //        }
        //    }
        //}
    }
}
