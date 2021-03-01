using System;

namespace _P__String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(statement);

            Console.WriteLine("Choose a word from the sentences above. >>");
            string word = Console.ReadLine();
            if (statement.ToLower().Contains(word))
            {
                Console.WriteLine("What word would you change your selected word too?>>");
                string wordChange = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry I could not find your word {" + word + "}");
                

                for (int i = length - 1; i < Convert.ToInt32(word); i++)
                {
                    int WordCount = word.Length;
                    Console.WriteLine()
                    
                }
                
               
                
            }
           

           



        }
    }
}
