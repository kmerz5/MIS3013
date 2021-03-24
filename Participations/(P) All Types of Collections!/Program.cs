using System;
using System.Collections.Generic;

namespace _P__All_Types_of_Collections_
{
    class Program
    {
        static void Main(string[] args)
        {
    //Problem 1
           /* string[] SubjectNames = new string[3];
            string[] ClassNumbers = new string[3];

            string answer;


            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the course name.>>");
                answer = Console.ReadLine();
                SubjectNames[i] = answer;

                Console.WriteLine("Please enter the course number assoicated with that course.>>");
                answer = Console.ReadLine();
                ClassNumbers[i] = answer;

            }
            Console.WriteLine();
            Console.WriteLine("Your classes are as follows:");
            Console.WriteLine(SubjectNames[0] + ClassNumbers[0]);
            Console.WriteLine();
            Console.WriteLine(SubjectNames[1] + ClassNumbers[1]);
            Console.WriteLine();
            Console.WriteLine(SubjectNames[2] + ClassNumbers[2]);

 //___________________________________________________________________________________________
    //Problem 2
            List<double> examScores = new List<double>();

            do
            {
                Console.WriteLine("Please enter your exam score.");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer);
                examScores.Add(score);

                Console.WriteLine("Do you have another score to enter?");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            double avg = 0;
            double sum = 0;

            foreach (double score in examScores)
            {
                sum += score;

            }
            avg = sum / examScores.Count;
            Console.WriteLine("The average for your exam scores is " + avg);*/


//_________________________________________________________________________________________
    //Problem 3
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.99);
            courseGrades["MIS3013"].Add(0.99);
            courseGrades["MIS3013"].Add(0.99);
            double sum1 = 0;
            foreach (string MIS3013 in courseGrades.Keys)
            {
                List<double> grades = courseGrades[MIS3013];
                for (int i = 0; i < grades.Count; i++)
                {
                    sum1 += grades[i];

                }
            }

            courseGrades.Add("MIS3033", new List<double>());
            courseGrades["MIS3033"].Add(0.99);
            courseGrades["MIS3033"].Add(0.99);
            courseGrades["MIS3033"].Add(0.99);
            double sum2 = 0;
            foreach (string MIS3033 in courseGrades.Keys)
            {
                List<double> grades = courseGrades[MIS3033];
                for (int i = 0; i < grades.Count; i++)
                {
                    sum2 += grades[i];
                }

            }

            courseGrades.Add("MIS3213", new List<double>());
            courseGrades["MIS3213"].Add(0.99);
            courseGrades["MIS3213"].Add(0.99);
            courseGrades["MIS3213"].Add(0.99);
            double sum3 = 0;
            foreach (string MIS3213 in courseGrades.Keys)
            {
                List<double> grades = courseGrades[MIS3213];
                for (int i = 0; i < grades.Count; i++)
                {
                    sum3 += grades[i];

                }

            }

            //other way
            //List<double> MIS3013Grades = new List<double>();
            //MIS3013Grades.Add(0.70);
            //CourseGrades.Add("MIS3013, MIS3013Grades);



            Console.WriteLine("Your average grades for MIS3013 is: " + (sum1/3).ToString("P2"));
            Console.WriteLine("Your average grades for MIS3033 is: " + ((sum2-sum1) / 3).ToString("P2"));
            Console.WriteLine("Your average grades for MIS3213 is: " + ((sum3 - sum2)  / 3).ToString("P2"));

            //going to have to output the grades one by one 





        }
    }
}
