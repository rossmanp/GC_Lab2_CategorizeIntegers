﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Pete Rossman
// Grand Circus .NET Bootcamp Lab 2
// March 28, 2017

namespace GC_Lab2_CategorizeIntegers
{
    //This program takes an integer as input, and then displays
    //a message based on the inputted integer.
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0;
            //The do while loop runs until an integer from 1 to 100
            //is obtained as input.
            do
            {
                Console.WriteLine("Type in an integer from among 1 to 100: ");
                myInt = int.Parse(Console.ReadLine());
                if (myInt < 1 || myInt > 100)
                {
                    Console.WriteLine("The integer you input is not an integer from 1 to 100!");
                }
            }
            while (myInt < 1 || myInt > 100);

            //The following conditionals display whether the input is odd or even
            //and in some cases print the number.

            if (myInt % 2 == 1)
            {
                Console.WriteLine("Your number is " + myInt + " and it is odd.");
            }
            else if (myInt > 60)
            {
                Console.WriteLine("Your number is " + myInt + " and it is even.");
            }
            else if (myInt <= 60 && myInt >= 26)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is even and less than 25.");
            }
            Console.ReadLine();
        }
    }
}
