using System;

namespace SumOf3
{
    class Program
    {
        static double ClassLevelVariable = 5;
        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777; //local variable that is a constant

            //cant do this because it is a constant value MAGIC_NUMBER = 8;
            ClassLevelVariable = 8;

            double heresMyDouble;
            double heresMyDouble2;
            double heresMyDouble3;

            Console.WriteLine($"Please enter a double>>");
            string answer = Console.ReadLine();
            heresMyDouble = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter a double>>");
            answer = Console.ReadLine();
            heresMyDouble2 = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter a double>>");
            answer = Console.ReadLine();
            heresMyDouble3 = Convert.ToDouble(answer);

            double Sum = heresMyDouble + heresMyDouble2 + heresMyDouble3;

            Console.WriteLine($"The Sum Is " + Sum.ToString("N3"));

           

            Console.WriteLine($"The Solution Is " + (Sum * MAGIC_NUMBER));



        
        }
    }
}
