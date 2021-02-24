using System;

namespace _02_24_2021
{
    class Program
    {
        static void Main(string[] args)
        {
    //Add one to each number up to 100
            //start off with 0
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum = sum + 1;
                //sum +=i;
            }
            Console.WriteLine($"All the #'s added up from 1 to 100 is {sum.ToString}");
        }
    }
}
