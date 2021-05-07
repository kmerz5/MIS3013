using System;

namespace _P__Methods___Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Your application will prompt the user to enter a type of animal.  You will pass in the animal that 
             * the user typed into your method and then output the result.

            Create a method named Speak that accepts 1 parameter of type string and has a return type of string. 
            The method will return the sound that the animal makes.  Make this work for at least 3 animals 
            (Dog, Monkey, Goat), if your method does not know about the animal that they asked about make up a sound.

            Call your method from the main method and output a message to the user

            e.g. A dog makes the sound of ruff!*/

            string answer;
            Console.WriteLine("Please enter a type of animal into the console >>");
            answer = Console.ReadLine();
            string Output = speak(answer);  


        }
        static string speak(string answer)
        {
            if (answer.ToLower() == "dog")
            {
                Console.WriteLine("A dog says 'woof'!");

            }
            else if (answer.ToLower() == "monkey")
            {
                Console.WriteLine("A money says 'oohoohaahaah'");

            }
            else if (answer.ToLower() == "goat") 
            {
                Console.WriteLine("A goat says 'bahahahaha'");

            }
            else
            {
                Console.WriteLine($"{answer} makes the noise 'oooooooop'");
            }
            return answer;
        }
    }
}
