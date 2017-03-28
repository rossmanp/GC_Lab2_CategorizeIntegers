using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab2_CategorizeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0;
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
