using System;

namespace MidTerm_Extra_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
         //Generate a random number
            Random rand = new Random();
            int rand1 = rand.Next(1, 51);
            int rand2 = rand.Next(1, 51);
//__________________________________________________________________________________________________
         // Use substring and Indexof
         //EX:wanting the first word, finding the first space and just output what is before
            Console.WriteLine("please enter a sentence into the console.");
            string answer = Console.ReadLine();
            string Sentence = answer;
            string NewSentence = Sentence.Substring(0, Sentence.IndexOf(" "));
            Console.WriteLine(NewSentence);
//_______________________________________________________________________________________________
         //difference between IF, FOR, and WHILE loops
            //IF EXAMPLE - ask the user to pick a word from this sentence, if the word they chose is in the sentence, ask them to replace it with
            //a different word. If their word does not exist in the sentence, tell them that it doesnt exist
            string statement = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(statement);
            Console.WriteLine(" ");

            Console.WriteLine("Please pick a word fromt the above statement.");
            answer = Console.ReadLine();
            string word = answer.ToLower();

            if (statement.ToLower().Contains(word))
            {
                Console.WriteLine("What would you like to replace " + word + " with?");
                string NewWord = Console.ReadLine();
                string NewStatement = statement.Replace(word, NewWord);
                Console.WriteLine(NewStatement);
                
            }
            else
            {
                Console.WriteLine("Sorry, " + word + " does not exist in the above sentence.");
                Environment.Exit(-1);
            }
            Console.WriteLine(" ");

//-----------------------------------------------------------

            //FOR Example: Tuition is currently 12,000 and it will increase by 5% for the next 7 years. Output what the tuition will be for
            //each of the next 7 years.
            double tuition = 12000;
            double increase = .05;
            double tuitionincrease = tuition + (tuition * increase);
            for (int i = 1; i < 8; i++)
            {
                tuition = tuition + (tuition * increase);
                Console.WriteLine("The tuition for year " + i + " is " + tuition.ToString("C0"));
            }
            Console.WriteLine(" ");

            //-----------------------------------------------------------

            //WHILE Example: Have two numbers and ask the user to guess a number between those two numbers. If they get it right, tell them
            //congrats, if they do not get it right, have it keep repeating the question untill they do.
            int num1 = 1;
            int num2 = 5;

            Console.WriteLine("Guess a number between " + num1 + " and " + num2);
            answer = Console.ReadLine();
            int guess = Convert.ToInt32(answer);

            Random RANDNUMBER = new Random();
            int ANSWER = RANDNUMBER.Next(num1, num2);

            while (ANSWER != guess)
            {
                Console.WriteLine("Guess a number between " + num1 + " and " + num2);
                answer = Console.ReadLine();
                guess = Convert.ToInt32(answer);
            }
            Console.WriteLine("Congrats! You guessed correctly!");


            //TryParse Example
        }
    }
}
