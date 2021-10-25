using System;

namespace BeshinciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to find the sum of first 10 natural numbers
            Console.WriteLine ("The first 10 natural numbers is:");
            int sum = 0;
            for (short x = 1; x <= 10; x++)
            {
                sum+= x;
                Console.Write(x + " ");
                if (x == 10) {
                    Console.WriteLine("The sum is:" + sum );
                }
            }
        }
    }
}
