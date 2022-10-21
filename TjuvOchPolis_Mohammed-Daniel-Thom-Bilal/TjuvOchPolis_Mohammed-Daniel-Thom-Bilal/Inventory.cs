using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis_Mohammed_Daniel_Thom_Bilal
{
    internal class Inventory
    {
        public static void Stealing(List<string> stolenproperties, List<string> properties)
        {
            //Kollar om Medborgares inventory är tom
            if (properties.Count == 0)
            {


            }
            //Kollar om medborgatres inventory har något i sig, tar sedan bort random item ur medborgare och stoppar det i tjuvens inventory.
            else if (properties.Count == 1)
            {
                stolenproperties.Add(properties[0]);
                properties.RemoveAt(0);
            }
            //Tar ett random item
            else
            {
                Random random = new Random();
                int randomnumber = random.Next(1, properties.Count);

                stolenproperties.Add(properties[randomnumber]);
                properties.RemoveAt(randomnumber);
            }
        }
        internal static void Arrest(List<String> seized, List<string> stolenproperties)
        {
            if (stolenproperties.Count == 0)
            {

            }
            else
            {
                //Polis koller tjuvs inventory samt tar allt i tjuvs inventory, tömmer den och stoppar allt i polis inventory.
                for (int i = 0; i < stolenproperties.Count; i++)
                {
                    seized.Add(stolenproperties[i]);
                }
                stolenproperties.Clear();
            }
        }
    }
    
    class StolenProperties : Inventory
    {
        //Skapar en lista för tjuvens inventory
        public static List<string> CreateStolenProperties()
        {
            List<String> stolenproperties = new List<string>();
            return stolenproperties;
        }
    }
    class Seized : Inventory
    {
        //Skapar en lista för polisens inventory
        public static List<string> CreateSeized()
        {
            List<String> seized = new List<string>();
            return seized;
        }
    }
    class Properties
    {
        //Skapar en lista för Medborgares inventory samt lägger 4 items i den.
        public static List<String> CreateProperties()
        {
            List<String> properties = new List<string>();
            properties.Add("Nycklar");
            properties.Add("Mobiltelefon");
            properties.Add("Pengar");
            properties.Add("Klocka");
            return properties;
        }
    }
}
