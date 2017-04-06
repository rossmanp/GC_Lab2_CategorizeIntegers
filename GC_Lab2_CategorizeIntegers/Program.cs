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
            List<int> allInts = new List<int>();
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            while (runProgram)
                {
                //The do while loop runs until an integer from 1 to 100
                //is obtained as input.
                myInt = 0;
                     do
                     {
                       Console.WriteLine(name + ", type in an integer from among 1 to 100: ");

                        try
                        {
                            myInt = int.Parse(Console.ReadLine());
                            if (myInt < 1 || myInt > 100)
                            {
                                throw new IndexOutOfRangeException();
                            }
                        }                       
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a number!");
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Please enter a number from 1 to 100!");
                        }                      
                     }
                      while (myInt < 1 || myInt > 100);

                //The following conditionals display whether the input is odd or even
                //and in some cases print the number.
                    allInts.Add(myInt);
                    PrintOutput(myInt, name);
                    bool runPrintLoop = true;
                //The user is asked if he or she wants to use the program again; if no
                //is indicated, the program exits.
                while (runPrintLoop)
                {
                    Console.Write("Do you want to input another integer or print all integers so far, " + name + "? (y/n/print):");
                    runAgain = Console.ReadLine();

                    if (runAgain.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye " + name + "!");
                        runProgram = false;
                        runPrintLoop = false;
                        Console.ReadLine();
                    }
                    else if (runAgain.ToLower() == "print")
                    {
                        Console.WriteLine("The list of numbers input so far is:");
                        foreach (int i in allInts)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        runPrintLoop = false;
                    }
                }   
            }
        }
        public static bool IsIntOdd(int number)
        {
            if ((number % 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PrintOutput(int myInt, string name)
        {
            if (IsIntOdd(myInt))
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
            else if (myInt < 26)
            {
                Console.WriteLine(name + ", your number is even and less than 25.");
            }
            else
            {
                Console.WriteLine("Unknown error occurred!");
            }
        }
            
   }
}
