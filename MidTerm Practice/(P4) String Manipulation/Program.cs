using System;

namespace _P4__String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a class variable, of type string, that will hold the value:
             * "Programming today is a race between software engineers striving to build bigger 
             * and better idiot-proof programs, and the universe trying to build bigger and better idiots. 
             * So far, the universe is winning." DONE
             * 
             * Start your application off by showing the user the above sentence.  DONE
             * 
             * Then ask the user for input on what word they want to look for in the above sentence, 
             * and what word they want to change it to (easier if this is two separate inputs). DONE
             * 
             * If the word they want to look for is not present in the sentence, output "Sorry, 
             * I could not find your word {INSERT THEIR WORD HERE}." and then output their word they 
             * wanted you to look for in reverse order, using a loop (e.g. if their word was puppy, 
             * you would output yppup). 
             * 
             * If the word does exist in the sentence, replace all occurrences of 
             * it with the word they wanted to replace it with and output the new sentence with the words replaced.DONE*/

            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(sentence);

            Console.WriteLine(" ");
            Console.WriteLine("What word do you want to look for in the sentence above?");
            string word = Console.ReadLine();
            if (sentence.ToLower().Contains(word.ToLower()))
            {
                Console.WriteLine("What would you like to replace " + word.ToLower() + " with?");
                string replaceword = Console.ReadLine();
                string NewSentence = sentence.Replace(word.ToLower(), replaceword.ToLower());
                Console.WriteLine(NewSentence);
            }
            else
            {
                Console.WriteLine("Sorry, I could not find your word " + "{" + word + "}");
                string ReverseWord = " ";
                for (int i = word.Length-1; i >= 0; i--)
                {
                    ReverseWord += word[i];
                }
                Console.WriteLine(" ");
                Console.WriteLine(ReverseWord);
            }
        }
    }
}
