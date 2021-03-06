﻿using System;
//Write a program, which reads a food product name, volume, energy content per 100ml and sugar content per
//100ml.Calculate the energy and sugar content for the given volume and print them on the console in the following
//format:
// Name – as per the input
// Volume – integer, suffixed by “ml” (e.g. “220ml”)
// Energy content – integer, suffixed by “kcal” (e.g. “500kcal”)
// Sugar content – integer, suffixed by “g” (e.g. “30g”)

namespace _4.Beverage_Labels
{
    class Labels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double kcal = ((double)energy / 100) * volume;
            double sug = ((double)sugar / 100) * volume;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sug}g sugars");
        }
    }
}
