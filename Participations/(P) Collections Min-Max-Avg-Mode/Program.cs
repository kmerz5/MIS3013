using System;
using System.Collections.Generic;

namespace _P__Collections_Min_Max_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ExamGrades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Enter your exam score. >>");
                answer = Console.ReadLine();
                double Useranswer = Convert.ToDouble(answer);

                ExamGrades.Add(Useranswer);

                Console.WriteLine("Do you have another exam score? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
            



        }
    }
}
