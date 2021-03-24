using System;
using System.Collections.Generic;

namespace Z_Collections_Median__Average__Mode_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            List<double> examScores = new List<double>();

            do
            {
                Console.WriteLine("Enter your exam score: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); //assuming we dont need validation
                examScores.Add(score);//store value in the collection to access it later

                Console.WriteLine("do you have another exam score to enter, yes or no?>>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
        //FINDING THE MINIMUM FOR THE COLLECTION
            double min = examScores[0];

            foreach (double score in examScores)
            {
                if (score < min)
                {
                    min = score;

                }

            }
            Console.WriteLine("The minimum value for the exam scores is: " + min.ToString("N2"));

        //FINDING THE MAXIMUM FOR THE COLLECTION
            double max = examScores[0];
            double sum = 0;
                double avg = 0;

            foreach (double score in examScores)
            {
                if (score > max)
                {
                    max = score;

                }
                //finding the average
                sum += score;
                
                

            }
            Console.WriteLine("The maximum value for the exam scores is: " + max.ToString("N2"));
            avg = sum / examScores.Count;

        //FINDING THE MODE FOR THE COLLECTION
            Dictionary<double, int> exams = new Dictionary<double, int>();
            foreach (double score in examScores)
            {
                if (exams.ContainsKey(score) == true)
                {
                    exams[score] = exams[score] + 1;

                }
                else
                {
                    exams.Add(score, 1);//cant start at 0 or we will be 1 off the entire time
                }

            }

            int highestoccurance = 0;
            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] > highestoccurance)
                {
                    highestoccurance = exams[scoreKey];

                }

            }
            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] == highestoccurance)
                {
                    Console.WriteLine(exams[scoreKey] + " occurs the most.");

                }

            }
        }
    }
}
