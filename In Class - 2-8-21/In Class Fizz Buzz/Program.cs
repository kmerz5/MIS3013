using System;

namespace In_Class_Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumberBetween1And100 = rand.Next(1, 101);

            if (randomNumberBetween1And100 % 3 == 0
                && randomNumberBetween1And100 % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

           else if (randomNumberBetween1And100 % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else if (randomNumberBetween1And100 % 3 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                Console.WriteLine($"{randomNumberBetween1And100}");
            }
        }
    }
}
