using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*GPA
                Ask the user to input their grade percentage (e.g. the use will enter 98 if they had an 
            overall grade of 98% in their course) for their Accounting, Marketing, Economics and MIS courses. DONE
            
            Assume each course is worth 3 credit hours.  
            
            Once you have all of their grades output what letter grade DONE
            they earned for each course (e.g. Your letter grade for {Accounting/Marketing/whichever one you are 
            outputting} is {A/B/C/D/F}).  After you have output all of their letter grades, output their overall GPA 
            for the semester using the formula:
            LOOK AT THE CANVAS ASSIGNMENT FOR THE FORMULA*/

            
            Console.WriteLine("What is your grade percentage for accounting?");
            string answer = Console.ReadLine();
            double OverallAccounting = Convert.ToDouble(answer);

            string AccountingLetterGrade;
            if (OverallAccounting >= 90)
            {
                AccountingLetterGrade = "A";
            }
            else if (OverallAccounting >=80)
            {
                AccountingLetterGrade = "B";
            }
            else if (OverallAccounting >= 70)
            {
                AccountingLetterGrade = "C";
            }
            else if (OverallAccounting >= 60)
            {
                AccountingLetterGrade = "D";
            }
            else
            {
                AccountingLetterGrade = "F";
            }

            double AccountingGPA;
            if (OverallAccounting >= 90)
            {
                AccountingGPA = 4.0;
            }
            else if (OverallAccounting >= 80)
            {
                AccountingGPA = 3.0;
            }
            else if (OverallAccounting >= 70)
            {
                AccountingGPA = 2.0;
            }
            else if (OverallAccounting >= 60)
            {
                AccountingGPA = 1.0;
            }
            else
            {
                AccountingGPA = 0;
            }

           

            Console.WriteLine("What is your grade percentage for marketing?");
            answer = Console.ReadLine();
            double OverallMarketing = Convert.ToDouble(answer);

            string MarketingLetterGrade;
            if (OverallMarketing >= 90)
            {
                MarketingLetterGrade = "A";
            }
            else if (OverallMarketing >= 80)
            {
                MarketingLetterGrade = "B";
            }
            else if (OverallMarketing >= 70)
            {
                MarketingLetterGrade = "C";
            }
            else if (OverallMarketing >= 60)
            {
                MarketingLetterGrade = "D";
            }
            else
            {
                MarketingLetterGrade = "F";
            }

            double MarketingGPA;
            if (OverallMarketing >= 90)
            {
                MarketingGPA = 4.0;
            }
            else if (OverallMarketing >= 80)
            {
                MarketingGPA = 3.0;
            }
            else if (OverallMarketing >= 70)
            {
                MarketingGPA = 2.0;
            }
            else if (OverallMarketing >= 60)
            {
                MarketingGPA = 1.0;
            }
            else
            {
                MarketingGPA = 0;
            }


            Console.WriteLine("What is your grade percentage for Economics?");
            answer = Console.ReadLine();
            double OverallEconomics = Convert.ToDouble(answer);
            string EconomicsLetterGrade;
            if (OverallEconomics >= 90)
            {
                EconomicsLetterGrade = "A";
            }
            else if (OverallEconomics >= 80)
            {
                EconomicsLetterGrade = "B";
            }
            else if (OverallEconomics >= 70)
            {
                EconomicsLetterGrade = "C";
            }
            else if (OverallEconomics >= 60)
            {
                EconomicsLetterGrade = "D";
            }
            else
            {
                EconomicsLetterGrade = "F";
            }

            double EconomicsGPA;
            if (OverallEconomics >= 90)
            {
                EconomicsGPA = 4.0;
            }
            else if (OverallEconomics >= 80)
            {
                EconomicsGPA = 3.0;
            }
            else if (OverallEconomics >= 70)
            {
                EconomicsGPA = 2.0;
            }
            else if (OverallEconomics >= 60)
            {
                EconomicsGPA = 1.0;
            }
            else
            {
                EconomicsGPA = 0;
            }

            Console.WriteLine("What is your grade percentage for MIS?");
            answer = Console.ReadLine();
            double OverallMIS = Convert.ToDouble(answer);
            string MISLetterGrade;
            if (OverallMIS >= 90)
            {
                MISLetterGrade = "A";
            }
            else if (OverallMIS >= 80)
            {
                MISLetterGrade = "B";
            }
            else if (OverallMIS >= 70)
            {
                MISLetterGrade = "C";
            }
            else if (OverallMIS >= 60)
            {
                MISLetterGrade = "D";
            }
            else
            {
                MISLetterGrade = "F";
            }

            double MISGPA;
            if (OverallMIS >= 90)
            {
                MISGPA = 4.0;
            }
            else if (OverallMIS >= 80)
            {
                MISGPA = 3.0;
            }
            else if (OverallMIS >= 70)
            {
                MISGPA = 2.0;
            }
            else if (OverallMIS >= 60)
            {
                MISGPA = 1.0;
            }
            else
            {
                MISGPA = 0;
            }
            
            double OverallGPA = (AccountingGPA + MarketingGPA + EconomicsGPA + MISGPA) / 4;
            Console.WriteLine("Your letter grade for accounting is a(an) " +  AccountingLetterGrade);
            Console.WriteLine(" ");
            Console.WriteLine("Your letter grade for marketing is a(an)  " + MarketingLetterGrade);
            Console.WriteLine(" ");
            Console.WriteLine("Your letter grade for economics is a(an) " + EconomicsLetterGrade);
            Console.WriteLine(" ");
            Console.WriteLine("Your letter grade for MIS is a(an) " + MISLetterGrade);
            Console.WriteLine(" ");
            Console.WriteLine("Your overall GPA is " + OverallGPA.ToString("N2"));

            

            





            /*Trivia Quiz
                You and your friends get into an argument over who is the smartest. You decide to settle it once 
            and for all by creating a five question trivia quiz for your friends to take. You determine you will make 
            the trivia quiz using a C# Console App in Visual Studio. Each question will be a true/false statement. 
            For example:Question 1: Prof. Ackerman is bald by choice. (T/F)
            After the user answers all five questions, the app should output their final score out of 5, 
            as well as the percent of questions they answered correctly. If the user does not answer true/false, 
            the application should quit immediately.*/
        }
    }
}
