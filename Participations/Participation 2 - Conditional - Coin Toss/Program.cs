using System;

namespace Participation_2___Conditional___Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess heads or tails");
            string answer = Console.ReadLine(); 
           

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            Console.WriteLine($"{randomNbr}");
            randomNbr = Convert.ToString(answer);

            int headsortails = Convert.ToInt32(answer);
            

        }
    }
}
