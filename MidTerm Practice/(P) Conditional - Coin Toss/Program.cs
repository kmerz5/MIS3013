using System;

namespace _P__Conditional___Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Prompt the user to pick heads or tails, and then generate a random number, 
             * using the Random (Links to an external site.) class, generate a random number 
             * that has a range of just two numbers (e.g. it should just be random between 0 
             * and 1 or 1 and 2 so that you have two options, heads or tails).  
             * Tell the user what side the coin landed on (heads or tails) and then whether or 
             * not their guess was right or wrong. 
             * Display the developer name (store as a constant) before the user exits the application.*/

            Console.WriteLine("Pick heads or tails>>");
            string answer = Console.ReadLine();

            Random Rand = new Random();
            int RandNumber = Rand.Next(1, 3);

            if (RandNumber == 1)
            {
                Console.WriteLine("The coin landed on heads.");
            }
            else
            {
                Console.WriteLine("The coin landed on heads.");
            }

            if (answer.ToLower() == "heads" && RandNumber == 1)
            {
                Console.WriteLine("Your guess was correct!");
            }
            else if (answer.ToLower() == "tails" && RandNumber == 2)
            {
                Console.WriteLine("Your guess was correct!");
            }
            else
            {
                Console.WriteLine("Your guess was incorrect.");
            }

            const string DeveloperInfo = "Kylie Merz - Student";
            Console.WriteLine(" ");
            Console.WriteLine("Developer Info: " + DeveloperInfo);


        }
    }
}
