﻿using System;

namespace _P__All_Types_of_Collections_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] SubjectNames = new string[3];
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


            

        }
    }
}
