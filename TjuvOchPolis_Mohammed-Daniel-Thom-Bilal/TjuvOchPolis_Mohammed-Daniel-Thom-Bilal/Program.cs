// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using TjuvOchPolis_Mohammed_Daniel_Thom_Bilal;
Persons randomDirection_ = new Persons();
int j = 0;
Police polis = new Police();
Civilian civilian = new Civilian();
Thief thief = new Thief();
List<Persons> poliser = new List<Persons>();
List<Persons> thiefs = new List<Persons>();
List<Persons> civillians = new List<Persons>();
int personer = 0;
int tagen = 0;
    for (int i = 0; i < 7; i++)
    {
        poliser.Add(new Police());
    }
    for (int i = 0; i < 20; i++)
    {
        civillians.Add(new Civilian());
    }
    for (int i = 0; i < 15; i++)
    {
        thiefs.Add(new Thief());
    }
while (true)
{
    Random rnd = new Random();
    int random = rnd.Next(1, 4);
    polis.CordX = randomDirection_.randomDirectionX(random);
    polis.CordY = randomDirection_.randomDirectionY(random);
    Console.Clear();
    for (int i = 0; i < poliser.Count; i++)
    {
        Console.WriteLine(personer + " " + polis.P + poliser[i].CordX + " " + poliser[i].CordY);
    }
    for (int i = 0; i < thiefs.Count; i++)
    {
            Console.WriteLine(personer + " " + thief.T + " " + thiefs[i].CordX + " " + thiefs[i].CordY);
        randomDirection_.randomDirectionX(random);
    }
    for (int i = 0; i < civillians.Count; i++)
    {
            Console.WriteLine(personer + " " + civilian.C + " " + civillians[i].CordX + " " + civillians[i].CordY);
        randomDirection_.randomDirectionX(random);
        foreach (Persons rånade in thiefs)
        {
            if (rånade.CordX == civillians[i].CordX && rånade.CordY == civillians[i].CordY)
            {
                Console.WriteLine("tjuv råna medborgare " + civillians[i].CordX + " " + civillians[i].CordY);
            }
        }        
    }
    
    for (int i = 0; i < personer; i++)
    {
        if (i < 5 && thiefs[i].CordY == poliser[i].CordY && thiefs[i].CordX == poliser[i].CordX)
        {
            Console.WriteLine("X, polis grep tjuv");
        }
    }
    Console.ReadKey();
}

