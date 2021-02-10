using System;

namespace Participation_2___Conditional___Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the users guess
            //convert their guess into a string or our int to a string
            //1=heads
            //2=tails
            //convert the random number to heads or tails ( conditional)
            //tell the user if they guessed correctly (conditional)
            //output developer information

            Console.WriteLine("Guess heads or tails");
            string answer = Console.ReadLine(); 
           

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            Console.WriteLine($"{randomNbr}");

            if (randomNbr == 1)
            {
                Console.WriteLine("The coin landed on heads");
            }

            else 
            {
                Console.WriteLine("The coin landed on tails");
            }

            if (answer == "heads" && randomNbr == 1)
            {
                Console.WriteLine("Your guess was correct");
            }
            else if (answer == "tails" && randomNbr == 2)
            {
                Console.WriteLine("Your guess was correct");
            }
            else
            {
                Console.WriteLine("Your guess was incorrect");
            }

            const string DeveloperInfo = "Kylie Merz-Student";

            Console.WriteLine("The developer was" + " " + DeveloperInfo);


            

        }
    }
}
