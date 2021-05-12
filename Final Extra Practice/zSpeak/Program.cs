using System;

namespace zSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Please choose a type of animal.>>");
            answer = Console.ReadLine();
            Speak(answer);

        }

        static string Speak(string answer)
        {
            if (answer.ToLower() == "dog")
            {
                Console.WriteLine("The sound a dog makes is 'woof'");

            }
            else if (answer.ToLower() == "monkey")
            {
                Console.WriteLine("The sound a monkey makes is 'oohoohaahaah'");

            }
            else if (answer.ToLower() == "goat")
            {
                Console.WriteLine("The sound a goat makes is 'bahahaha'");

            }
            else
            {
                Console.WriteLine($"The sound a {answer} makes is 'ghghghgh'");
            }
            return answer;
        }
    }
}
