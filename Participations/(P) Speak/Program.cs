using System;

namespace _P__Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an animal: dog, monkey, or goat. >>");
            string answer = Console.ReadLine();
            string Output = speak(answer);
        }

        static string speak(string answer)
        {
            if (answer.ToLower() == "dog")
            {
                Console.WriteLine("The sound a " + answer + " makes is ruff!");

            }
            else if (answer.ToLower() == "monkey")
            {
                Console.WriteLine("The sound a " + answer + " makes is oohoohaahaah!");

            }
            else if (answer.ToLower() == "goat")
            {
                Console.WriteLine("The sound a " + answer + " makes is bahahahahaa!");

            }
            else
            {
                Console.WriteLine("The sound a(n) " + answer + " makes is merrrrrrrrp!");
            }
            return answer;

        }
}
    
}
