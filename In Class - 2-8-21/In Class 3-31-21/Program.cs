using System;
using System.Collections.Generic;

namespace In_Class_3_31_21
{
    class Program
    {
        static void Main(string[] args)
        {

        //DEFINING THE METHOD
        //when you call a method that is like when you call that entire block of code wherever you want it to be
        static double ValidateDoubleInput(string message)
        {
                double value;
                string answer;

                do
                {
                    Console.WriteLine(message);
                    answer = Console.ReadLine();

                    //bool isDouble = double.TryParse(answer, out value);

                } while (double.TryParse(answer, out value) == false);

                return value;
            
        }

        //example using the method
        List<double> gpas = new List<double>();
            string answer;

            do
            {
               double gpa =  ValidateDoubleInput("Please enter a GPA >>");
                gpas.Add(gpa);

                bool shouldContinue = AskUserToContinue(); //the parenthesis denote the function

                Console.WriteLine("Do you want to enter more numbers?>>");
                answer = Console.ReadLine();
            } while (AskUserToContinue() == true);

            //another example using the method above
            List<double> itemprices = new List<double>();
            do
            {
                double gpa = ValidateDoubleInput("Please enter an item price >>");
                gpas.Add(gpa);

                Console.WriteLine("Do you want to enter more numbers?>>");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');

        }

        private static bool AskUserToContinue() //clicking the lightbulb after typing |bool shouldContinue = AskUserToContinue();| and click create method
        {
            Console.WriteLine("Do you want to go again? Yes or No? >>");
            string answer = Console.ReadLine().ToLower();

            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Sorry, you must answer yes or no.");

                Console.WriteLine("Do you want to go again? Yes or No? >>");
                answer = Console.ReadLine();
            }

            if (answer == "yes")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
