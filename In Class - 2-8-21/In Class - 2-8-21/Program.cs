using System;

namespace In_Class___2_8_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next();

            Console.WriteLine("Please enter your favorite # (whole #'s only!) >>");
            //int luckyNumber = Convert.ToInt32(Console.ReadLine());//first way
           String answer = Console.ReadLine();//second way part 1
            //luckyNumber = Convert.ToInt32(answer); //Second way part 2
            int luckyNumber;
            bool isInteger = int.TryParse(answer, out luckyNumber);

            if(isInteger == false) //only do the rest of the program if what we are given is an integer
            {
                Console.WriteLine($"{answer} was not a valid integer. Goodbye!");
                //return; //another way to exit the enviornment
                Environment.Exit(-1); //exiting the enviornment
            } 

            // tab twice to fill out the rest of the statement after typing if
            int remainder = luckyNumber % 7; // will give us back an integer now we need to convert to a true or false
            if (remainder == 0) //== because if just = meaning if remainder has a value of zero
            {
                Console.WriteLine($"{luckyNumber} is truly a lucky number!");
            }
            else if (luckyNumber % 13 == 0)
                {
                    Console.WriteLine($"{luckyNumber} is really an unlucky number!");
                }
            else
            {
                Console.WriteLine($"{luckyNumber}");
            }

            Console.WriteLine("What is your favorite type of pet? >>");
            answer = Console.ReadLine();

            
            switch (answer.ToLower()) //will convert all the letters they type to lower or .ToUpper to uppercase
            {
                case "dog":
                    Console.WriteLine("Cool me too!");
                    break;
                case "cat":
                    Console.WriteLine("If you say so");
                    break;
                default:
                    Console.WriteLine($"Who would ever have a pet {answer}?!?");
                    break;
            }

        }
    }
}
