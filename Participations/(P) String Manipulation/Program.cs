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
            //He did if(statement.ToLower().Contains(word) == TRUE)
            //^^changing the statement all to lowercase and seeing if the statement contains the word they chose
            {
                Console.WriteLine("What word would you change your selected word too?>>");
                string wordChange = Console.ReadLine();
                String NewSentence = statement.Replace(word, wordChange);
                //^^^This is picking the word they chose and changing it to the new word they picked
                Console.WriteLine(NewSentence);
            }
            else
            {
                Console.WriteLine("Sorry I could not find your word {" + word + "}");

                string ReverseWord = "";
                for (int i = word.Length-1; i >= 0; i--)
                {
                    ReverseWord += word[i];

                }
                Console.WriteLine(" ");
                Console.WriteLine(ReverseWord);
                
            }

            /* Explanation for the reverse word portion
             * 0  1  2  3  4
             * P  U  P  P  Y
             * Length = 5
             * for(int i = word.Length-1; i >= 0; i++) - LENGTH WILL HAVE IT START AT THE END
             * >= 0 SO THAT IT RUNS TO THE LETTER IN THE 0 POSITION
             * i-- IS TO TELL IT TO GO BACKWARDS DOWN THE WORD, SUBTRACTING EACH TIME UNTILL IT GOES TO THE 0 POSITION 
             * word.Length-1 - BECAUSE THE LENGTH FOR PUPPY IS 5 BUT WE REALLY WANT TO START AT POSITION 4
            -  ReverseWord += word[i] IS TELLING IT THAT THE VARIABLE REVERSEWORD IS THE WORD GOING BY I WHICH WILL
            START FROM THE END OF THE WORD AND GO BACKWARDS AND OUTPUT EACH LETTER AS IT GOES ALONG
             - string ReverseWord = '; - HAVING THIS STRING START FROM ZERO, BLANK SLATE TO PUT THE CONCATONATED 
            CHARACTERS FROM THE LOOP*/
           

           



        }
    }
}
