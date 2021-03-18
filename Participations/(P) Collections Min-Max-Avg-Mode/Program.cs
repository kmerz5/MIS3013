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

            Dictionary<double, int> gradelist = new Dictionary<double, int>();
            for (int i = 0; i < ExamGrades.Count; i++)
            {
                if (gradelist.ContainsKey(ExamGrades[1]))
                {
                    int value;
                    if (gradelist.TryGetValue(ExamGrades[i], out value))
                    {
                        gradelist[ExamGrades[i]] = value + 1;

                    }

                }
                else
                {
                    gradelist.Add(ExamGrades[i],1);
                }

            }
            gradelist = gradelist.OrderByDescending(u => u.Value).ToDictionary(z =>z.Key, y => y.Value);

            if (gradelist.First().Value > 1)
            {
                Console.WriteLine($"Mode:  {gradelist.First().Key}");

            }
            else
            {
                Console.WriteLine("There is no mode");
            }




        }
    }
}
