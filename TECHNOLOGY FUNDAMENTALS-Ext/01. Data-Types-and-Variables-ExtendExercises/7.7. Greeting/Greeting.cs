﻿using System;
//Write a program that enters first name, last name and age and prints "Hello, <first name> <last name>. You are <age> years old.". Use interpolated strings.

namespace _7._7.Greeting
{
    class Greeting
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string ageS = Console.ReadLine();
            int age = int.Parse(ageS);


            Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
        }
    }
}
