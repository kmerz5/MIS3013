using System;

namespace Loops___Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a maximum integer.>>");
            string max = Console.ReadLine();
            int maxvalue = Convert.ToInt32(max);
            Console.WriteLine("Choose a minimum integer.>>");
            string min = Console.ReadLine();
            int minvalue = Convert.ToInt32(min);

            

            Random rand = new Random();
            int randomnumber = rand.Next(minvalue, maxvalue);

            
               
                Console.WriteLine("What is your guess for the random number between {minvalue} and {maxValue}?>>");
               string Guess = Console.ReadLine();
           int Guessnumber = Convert.ToInt32(Guess);


            while (Guessnumber != randomnumber)
            {
                Console.WriteLine("Sorry! Guess Again!");
                Guess = Console.ReadLine();
                Guessnumber = Convert.ToInt32(Guess);
            }
           
            //ASK THEM FOR FAVORITE NUMBER, IF THEY DONT GIVE AN INTEGER, SEND THAT MESSAGE AND THEN ASK THE QUESTION AGAIN.
            //int favoritenumber;
            //Console.WriteLine("What's your favorite number? >>");
            //string answer = Console.ReadLine();

            //while (int.TryParse(answer, out favoritenumber) == false)
            //{
                //Console.WriteLine("incorrect value. you must enter an integer");
                //answer = Console.ReadLine();
            //}
        }
    }
}
