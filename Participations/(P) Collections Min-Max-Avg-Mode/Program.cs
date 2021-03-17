using System;
using System.Collections.Generic;
using System.Linq;

namespace _P__Collections_Min_Max_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ExamGrades = new List<double>();
            List<double> AvgGrades = new List<double>();
            double Useranswer;
            string answer;
            do
            {
                Console.WriteLine("Enter your exam score. >>");
                answer = Console.ReadLine();
                Useranswer = Convert.ToDouble(answer);

                ExamGrades.Add(Useranswer);

                Console.WriteLine("Do you have another exam score? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            
            double Sum = 0;
            double AverageGrade = 0;

           /* while (answer < ExamGrades)
            {
                Sum = Useranswer + Sum;
            }
            AverageGrade = Sum / ExamGrades.Count;
            Console.WriteLine("Count" + ExamGrades.Count);
            Console.WriteLine("Average: " + AverageGrade);*/




        }
    }
}
