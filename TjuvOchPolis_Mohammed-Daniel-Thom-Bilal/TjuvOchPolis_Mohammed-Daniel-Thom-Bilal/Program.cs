﻿// See https://aka.ms/new-console-template for more information
using TjuvOchPolis_Mohammed_Daniel_Thom_Bilal;

Random Random1 = new Random();
int RandomX = Random1.Next(0, 101);

Random Random2 = new Random();
int RandomY = Random2.Next(0, 26);

Person person = new Person(RandomX,RandomY);

foreach (Person person in Persons)
{
    console.Writeline();
}


