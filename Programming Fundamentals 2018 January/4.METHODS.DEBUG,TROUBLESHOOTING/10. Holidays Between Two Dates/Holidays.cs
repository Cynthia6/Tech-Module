﻿using System;
using System.Globalization;

//You are assigned to find and fix the bugs in an existing piece of code, using the Visual Studio debugger. You should
//trace the program execution to find the lines of code that produce incorrect or unexpected results.
//You are given a program (existing source code) that aims to count the non-working days between two dates given
//in format day.month.year(e.g.between 1.05.2015 and 15.05.2015 there are 5 non-working days – Saturday and
//Sunday).

namespace _10.Holidays_Between_Two_Dates
{
    class Holidays
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                   "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}