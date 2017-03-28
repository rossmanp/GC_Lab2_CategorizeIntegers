using System;
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
            string runAgain;           
            bool runProgram = true;

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            while (runProgram)
                { 
                     //The do while loop runs until an integer from 1 to 100
                     //is obtained as input.
                     do
                     {
                       Console.WriteLine(name + ", type in an integer from among 1 to 100: ");
                       int.TryParse(Console.ReadLine(), out myInt);
                       if (myInt < 1 || myInt > 100)
                       {
                          Console.WriteLine("Your input is not an integer from 1 to 100 " + name + " !");
                        }
                      }
                      while (myInt < 1 || myInt > 100);

                    //The following conditionals display whether the input is odd or even
                    //and in some cases print the number.

                    if (myInt % 2 == 1)
                    {
                        Console.WriteLine(name + ", your number is " + myInt + " and it is odd.");
                    }
                    else if (myInt > 60)
                    {
                        Console.WriteLine(name + ", your number is " + myInt + " and it is even.");
                    }
                    else if (myInt <= 60 && myInt >= 26)
                    {
                        Console.WriteLine(name + ", your number is even.");
                    }
                    else
                    {
                        Console.WriteLine(name + ", your number is even and less than 25.");
                    }

                    //The user is asked if he or she wants to use the program again; if no
                    //is indicated, the program exits.

                    Console.Write("Do you want to input another integer, " + name + "? (y/n):");
                    runAgain = Console.ReadLine();

                    if (runAgain.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye" + name + " !");
                        runProgram = false;
                        Console.ReadLine();
                    }
        }
      }
   }
}
