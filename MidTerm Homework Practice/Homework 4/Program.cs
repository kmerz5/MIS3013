using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vowels and Consonants
                Prompt the user to input a sentence.DONE  Once you have their sentence, figure out how many vowels 
            (a, e, i, o, u) and how many consonants are in the sentence.  Output the total number of consonants 
            and vowels in the following format (2 separate lines and the format specifier should be general with 
            0 decimal places!)*/


            /* Console.WriteLine("Please input a sentence.");
             string sentence = Console.ReadLine();
             sentence = sentence.ToLower();

             int vowels = 0;
             int consonants = 0;

             for (int i = 0; i < sentence.Length; i++)
             {
                 char letter = sentence[i];
                 if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                 {
                 vowels++;
                 }
                 else if ((letter == ' ' || letter == '!' || letter == '?' || letter == '\"' || letter == '\'' ||
                     letter == '1' || letter == '2' || letter == '3' || letter == '4' || letter == '5' ||
                     letter == '6' || letter == '7' || letter == '8' || letter == '9' || letter == ';' ||
                     letter == ':' || letter == '(' || letter == ')' || letter == '/' || letter == '&' ||
                     letter == '.' || letter == ',' || letter == '$' || letter == '*' || letter == '#'))
                 {

                 }
                 else
                 {
                     consonants++;
                 } 
             }
             Console.WriteLine("There were " + vowels.ToString("G0") + " vowels in your sentence.");
             Console.WriteLine("There were " + consonants.ToString("G0") + " consonants in your sentence");*/

            //-------------------------------------------------------------------------------------------------------------------

            /*l337 Converter
                Prompt the user to input a sentence.  Once you have their sentence 
            (Convert the sentence to all uppercase), you will convert their sentence to 'l337' 
            (Links to an external site.).  You will need to replace the letter on the left with the letter 
            on the right, using the replace() function in the String class, from the following table:

                        A	4
                        E	3
                        H	|-|
                        S	$
                        T	7
                        U	|_|
                        O	0 (this is the # 0)
                        P	 []D
            Since we are very excited about our application, we want to make sure that every 
            sentence ends with an exclamation mark!  If it already ends with an exclamation mark, 
            do not add another, otherwise concatenate a '!' at the end!*/

            Console.WriteLine("please input a sentence into the console.");
            string answer = Console.ReadLine();
            string Sentence = answer.ToUpper();

            Sentence = Sentence.Replace("A", "4");
            Sentence = Sentence.Replace("E", "3");
            Sentence = Sentence.Replace("H", "|-|");
            Sentence = Sentence.Replace("S", "$");
            Sentence = Sentence.Replace("T", "7");
            Sentence = Sentence.Replace("U", "|_|");
            Sentence = Sentence.Replace("O", "0");
            Sentence = Sentence.Replace("P", "[]D");

            //REMEMBER THE SENTENCE[SENTENCE.LENGTH-1]
            if (Sentence[Sentence.Length-1] != '!')
            {
                Console.WriteLine(Sentence + "!");
            }
            else
            {
                Console.WriteLine(Sentence);
            }













            /*Console.WriteLine("Please enter a sentence.");
            string answer = Console.ReadLine();
            string sentence = answer.ToUpper();

            sentence = sentence.Replace("A", "4");
            sentence = sentence.Replace("E", "3");
            sentence = sentence.Replace("H","|-|");
            sentence = sentence.Replace("S", "$");
            sentence = sentence.Replace("T", "7");
            sentence = sentence.Replace("U", "|_|");
            sentence = sentence.Replace("O", "0");
            sentence = sentence.Replace("P", "[]D");

            if (sentence[sentence.Length-1] != '!')
            {
                Console.WriteLine(sentence + "!");
            }
            else
            {
                Console.WriteLine(sentence);
            }*/

        }
}
}
