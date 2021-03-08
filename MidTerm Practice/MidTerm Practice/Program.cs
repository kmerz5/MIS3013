using System;

namespace MidTerm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a Visual C# Windows Console Application, name it SumOf3, that will prompt the user to 
                enter 3 different numbers (1 is a valid input and so is 5.5).  Add all 3 numbers together 
                and output the result displaying 3 decimal places.  Calculate a second value, where you multiply 
                the sum of the 3 numbers by a constant value of 7.777 (hint: make a constant variable that is 
                type double {just add the word 'const' before the data type to make it a constant}).*/

            Console.WriteLine("Please enter a number into the console>>");
            string answer = Console.ReadLine();
            double num1 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter a number into the console>>");
            answer = Console.ReadLine();
            double num2 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter a number into the console>>");
            answer = Console.ReadLine();
            double num3 = Convert.ToDouble(answer);

            double sum = num1 + num2 + num3;
            Console.WriteLine("The sum of all three of your numbers is " + sum.ToString("N3"));

            const double MAGIC_NUMBER = 7.777;
            double solution = sum * MAGIC_NUMBER;
            Console.WriteLine("The solution (the sum * the Magic Number) is " + solution.ToString("N3"));



            
        }
    }
}
