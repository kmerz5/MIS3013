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

            double AVERAGE;
            double TotalGrades = 0;
            for (int i = 0; i < ExamGrades.Count; i++)
            {
                TotalGrades = TotalGrades + ExamGrades[i];

            }
            AVERAGE = TotalGrades / ExamGrades.Count;
            Console.WriteLine("Average: " + AVERAGE);

            ExamGrades.Sort();
            Console.WriteLine("Minimum: " + ExamGrades[0]);
            Console.WriteLine("Maximum: " + ExamGrades[ExamGrades.Count - 1]);




        }
    }
}
