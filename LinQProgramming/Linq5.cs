﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQProgramming
{
    class Linq5
    {
        static void Main(string[] args)
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");


            var days = from WeekDay in dayWeek
                       select WeekDay;
            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();
        }
    }
}
