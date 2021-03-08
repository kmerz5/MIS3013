using System;

namespace _P__Loops___Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a new console application.   Generate a random number that the user will 
             * define the minimum value and the maximum value, using the Random (Links to an external site.) 
             * class.  Prompt the user to guess the random number until they successfully guess it.
             * Extra's:Validate that the user actually input a valid number, if they did not, 
             * prompt them to input a valid number 
             * (Hint: https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netcore-3.1 
             * (Links to an external site.) )*/

            Console.WriteLine("Pick the max value>>");
            string answer = Console.ReadLine();
            int max;
            if (int.TryParse(answer, out max) == true)
            {

            }
            else
            {
                Console.WriteLine("This is not a valid input! GoodBye.");
                Environment.Exit(-1);
            }

            Console.WriteLine("Pick the min value>>");
            answer = Console.ReadLine();
            int min;
            if (int.TryParse(answer, out min) == true)
            {

            }
            else
            {
                Console.WriteLine("This is not a valid input! Goodbye.");
                Environment.Exit(-1);
            }

            Random rand = new Random();
            int RandomNumber = rand.Next(min, max);

            Console.WriteLine("Guess the random number that will be between " + min + " and " + max);
            string guess = Console.ReadLine();
            int GUESS;
            if (int.TryParse(guess,out GUESS)==true)
            {

            }
            else
            {
                Console.WriteLine("That is not a valid input. Goodbye.");
                Environment.Exit(-1);
            }

            while (GUESS != RandomNumber)
            {
                Console.WriteLine("Guess again!");
                guess = Console.ReadLine();
                GUESS = Convert.ToInt32(guess);
            }
            if (GUESS == RandomNumber)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Good job!");
            }


        }
    }
}
