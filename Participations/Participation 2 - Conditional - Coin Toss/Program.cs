using System;

namespace Participation_2___Conditional___Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick heads or tails");
            string answer 
                


            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            Console.WriteLine($"{randomNbr}");

        }
    }
}
