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
            
            Once you have all of their grades output what letter grade
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

            Console.WriteLine("What is your grade percentage for marketing?");
            answer = Console.ReadLine();
            double OverallMarketing = Convert.ToDouble(answer);

            Console.WriteLine("What is your grade percentage for Economics?");
            answer = Console.ReadLine();
            double OverallEconomics = Convert.ToDouble(answer);

            Console.WriteLine("What is your grade percentage for MIS?");
            answer = Console.ReadLine();
            double OverallMIS = Convert.ToDouble(answer);





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
