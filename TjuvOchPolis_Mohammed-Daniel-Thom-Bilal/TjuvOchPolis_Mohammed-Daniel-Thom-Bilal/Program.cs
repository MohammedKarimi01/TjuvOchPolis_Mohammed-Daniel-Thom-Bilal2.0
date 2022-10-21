// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using TjuvOchPolis_Mohammed_Daniel_Thom_Bilal;
string[] rånad123;
Persons randomDirection_ = new Persons();
Police polis = new Police();
Civilian civilian = new Civilian();
Thief thief = new Thief();
List<Persons> poliser = new List<Persons>();
List<Persons> thiefs = new List<Persons>();
List<Persons> civillians = new List<Persons>();
List<int> randomsiffraPolisX = new List<int>();
List<int> randomsiffraPolisY = new List<int>();
List<int> randomsiffraCivillianX = new List<int>();
List<int> randomsiffraCivillianY = new List<int>();
List<int> randomsiffraThiefX = new List<int>();
List<int> randomsiffraThiefY = new List<int>();
int personer = 0;
int tagen = 0;
for (int i = 0; i < 7; i++)
    {
        poliser.Add(new Police());
        randomsiffraPolisX.Add(randomDirection_.randomDirection());
        randomsiffraPolisY.Add(randomDirection_.randomDirection());
}
    for (int i = 0; i < 20; i++)
    {
        civillians.Add(new Civilian());
        randomsiffraCivillianX.Add(randomDirection_.randomDirection());
        randomsiffraCivillianY.Add(randomDirection_.randomDirection());
}
    for (int i = 0; i < 15; i++)
    {
        thiefs.Add(new Thief());
    randomsiffraThiefX.Add(randomDirection_.randomDirection());
    randomsiffraThiefY.Add(randomDirection_.randomDirection());
    }
while (true)
{
    personer = 1;
    Console.Clear();
    for (int i = 0; i < poliser.Count; i++)
    {
        Console.WriteLine(personer + " " + polis.P + poliser[i].randomDirectionX(randomsiffraPolisX[i]) + " " + poliser[i].randomDirectionY(randomsiffraPolisY[i]));
        personer++;
    }
    for (int i = 0; i < thiefs.Count; i++)
    {
            Console.WriteLine(personer + " " + thief.T + " " + thiefs[i].randomDirectionX(randomsiffraThiefX[i]) + " " + thiefs[i].randomDirectionY(randomsiffraThiefY[i]));
        personer++;
      foreach (Persons tagens in poliser)
	{
        if (tagens.CordY == thiefs[i].CordY && tagens.CordX == thiefs[i].CordX)
	{
            Console.WriteLine("Tagen");
	}
	}
    }
    for (int i = 0; i < civillians.Count; i++)
    {
            Console.WriteLine(personer + " " + civilian.C + " " + civillians[i].randomDirectionX(randomsiffraCivillianX[i]) + " " + civillians[i].randomDirectionY(randomsiffraCivillianY[i]));
        personer++;
        foreach (Persons rånad in thiefs)
	{
        if (rånad.CordY == civillians[i].CordY && rånad.CordX == civillians[i].CordX)
	{
                rånad123[i] = personer + " Rånad";
                civilian.Items();
	}
	}
    }
            Console.WriteLine("------------");
    for (int i = 0; i < rånad123.Length; i++)
			{
        Console.WriteLine(rånad123[i]);
			}
    Console.ReadKey();
}

