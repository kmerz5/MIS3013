using System;

namespace _P__Functions___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kylie Merz";
            string classname = "MIS3013";
            string date = "March 31, 2021";
            Console.WriteLine(DeveloperInformation);

            Console.WriteLine("What application would you like to run? >>");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine("What is your first numerical value? >>");
            answer = Console.ReadLine();
            double val1 = Convert.ToDouble(answer);
            Console.WriteLine("What is your second numerical value? >>");
            answer = Console.ReadLine();
            double val2 = Convert.ToDouble(answer);
            do
            {
                if (answer == "add")
                {
                    

                }

            } while (true);


        }
        //ADD - "Add" - make sure it has a capital A
     /// <summary>
     /// Sums up two value
     /// </summary>
     /// <param name="val1">the left hand operand of the equation</param>
     /// <param name="val2">the right hand operand of the equation</param>
     /// <returns>the sum of the two numbers</returns>
        static double Add(double val1, double val2)
        {
            double number = val1 + val2;

            return number;

            //return val1 + val2
        }


        //SUBTRACT - "Subtract"
/// <summary>
/// subtracts two values
/// </summary>
/// <param name="val1">left hand operand</param>
/// <param name="val2">right hand operand</param>
/// <returns>the difference of two numbers</returns>
        static double Subtract(double val1, double val2)
        {
            double number = val1 - val2;

            return number;
        }

        //MULTIPLY - "Multiply
        static double Multiply(double val1, double val2)
        {
            double number = val1 * val2;

            return number;
        }

        //DIVIDE - "Divide"
        static double Divide(double val1, double val2)
        {
            double number = val1 / val2;

            return number;
        }

        //DEVELOPER INFORMATION - "DeveloperInformation"
        static void DeveloperInformation(string name, string classname, string date)
        {
            Console.WriteLine(name + classname + date);
        }
    }
}
