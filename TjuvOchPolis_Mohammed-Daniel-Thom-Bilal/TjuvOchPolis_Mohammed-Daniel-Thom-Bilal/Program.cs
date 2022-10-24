// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using TjuvOchPolis_Mohammed_Daniel_Thom_Bilal;
//string[] rånad123 = new string[];
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
int antalRånade = 0;
int antalGripna = 0;

for (int i = 0; i < 7; i++)//Skapar poliser, civilians och thieves med random direction
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
    Console.Clear();
    Console.WriteLine("Antal rånade: " + antalRånade);
    Console.WriteLine("Antal gripna: " + antalGripna);
    Console.WriteLine("-----------------------------------------------");
    personer = 1;
    
    for (int i = 0; i < poliser.Count; i++)//Skriver ut vart de olika personerna befinner sig
    {
        Console.WriteLine(personer + " " + polis.P + " " + poliser[i].randomDirectionX(randomsiffraPolisX[i]) + " " + poliser[i].randomDirectionY(randomsiffraPolisY[i]));
        personer++;
    }

    for (int i = 0; i < thiefs.Count; i++)
    {
            Console.WriteLine(personer + " " + thief.T + " " + thiefs[i].randomDirectionX(randomsiffraThiefX[i]) + " " + thiefs[i].randomDirectionY(randomsiffraThiefY[i]));
        personer++;
      foreach (Persons tagens in poliser)//Kollar om tjuv och polis kolliderar, skriver ut att tjuven blir tagen.
	  {
        if (tagens.CordY == thiefs[i].CordY && tagens.CordX == thiefs[i].CordX)
	    {
                antalGripna++;
                Console.WriteLine("Tagen");
                Thread.Sleep(1000);
	    }
	  }
    }

    for (int i = 0; i < civillians.Count; i++)
    {
            Console.WriteLine(personer + " " + civilian.C + " " + civillians[i].randomDirectionX(randomsiffraCivillianX[i]) + " " + civillians[i].randomDirectionY(randomsiffraCivillianY[i]));
        personer++;
        foreach (Persons rånad in thiefs)
	{
        if (rånad.CordY == civillians[i].CordY && rånad.CordX == civillians[i].CordX)//Kollar om civilian och tjuv kolliderar, skriver ut rånad.
	{
                Console.WriteLine("En person blev rånad.");
                antalRånade++;
                civilian.Items();
                Thread.Sleep(1000);
	}
	}
    }

    Thread.Sleep(500);
    //Console.ReadKey();
}

