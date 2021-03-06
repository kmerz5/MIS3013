﻿using System;

namespace MidTerm_Homework_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sale Total
                Create a Visual C# Windows Console Application that will prompt the user to enter what
            type of item they are purchasing,/ the quantity of the item, and the price for the item.DONE  
            Calculate the subtotal, the sales tax and the sales total (subtotal + sales tax) and output all 3 
            to the user.  Assume that the sales tax for your application is 8.5% (create a constant to store this 
            value and use the constant in your calculations)*/

           Console.WriteLine("What type of item are you purchasing?");
            string type = Console.ReadLine();

            Console.WriteLine("How many " + type + "'s are you purchasing?");
            string quantity = Console.ReadLine();
            int Count = Convert.ToInt32(quantity);

            Console.WriteLine("What is the price for this item?");
            string answer = Console.ReadLine();
            int price = Convert.ToInt32(answer);

            int subtotal = price * Count;
            double Tax = .085;
            double SalesTax = subtotal * Tax;
            double SalesTotal = subtotal + SalesTax;

            Console.WriteLine(" ");
            Console.WriteLine("Your subtotal is " + subtotal.ToString("C2"));
            Console.WriteLine("Your SalesTax is " + SalesTax.ToString("C2"));
            Console.WriteLine("Your SalesTotal is " + SalesTotal.ToString("C2"));



            /*Student Grade
                Create a Visual C# Windows Console Application that will prompt the user to enter their first name, 
            their last name, their student id number as well as their overall percentage grade for quizzes, 
            participations, homeworks, midterm and final exam.  Use the percentages from this class to calculate 
            their final grade and output it as a percent*/

            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine("What is your student ID number?");
            answer = Console.ReadLine();
            double ID = Convert.ToDouble(answer);

            Console.WriteLine("What was your overall grade for participations?");
            answer = Console.ReadLine();
            double participation = Convert.ToDouble(answer);

            Console.WriteLine("What was your overall grade for homeworks?");
            answer = Console.ReadLine();
            double homework = Convert.ToDouble(answer);

            Console.WriteLine("What was your overall grade for the midterm?");
            answer = Console.ReadLine();
            double midterm = Convert.ToDouble(answer);

            Console.WriteLine("What was your overall grade for the final exam?");
            answer = Console.ReadLine();
            double final = Convert.ToDouble(answer);

            double part = .08;
            double home = .12;
            double mid = .40;
            double Fi = .40;

            double partgrade = (participation * part)/100;
            double homegrade = (homework * home) / 100;
            double midgrade = (midterm * mid) / 100;
            double finalgrade = (final * Fi) / 100;

            double OverAllPercentage = partgrade + homegrade + midgrade + finalgrade;
            Console.WriteLine("Your overall grade for this course is " + OverAllPercentage.ToString("P2"));


        }
}
}
