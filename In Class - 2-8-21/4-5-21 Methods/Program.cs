using System;

namespace _4_5_21_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please input your grade in the course>>");
                double grade = Convert.ToDouble(Console.ReadLine());

                string LG = ConvertGradeToLetterGrade(grade);

                Console.WriteLine("Congradlations you have a(an) " + LG + " in the course!");

                Console.WriteLine("Do you want to convert another grade? Yes or No >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
            
        }
        /// <summary>
        /// Converts a standard grade (e.g. 98.5) to the appropriate letter grade (e.g. A)
        /// </summary>
        /// <param name="anyVariableNameWeWantThisBelongsToThisMethod">the grade to convert to a letter grade (98.5)</param>
        /// <returns>The letter grade in a sting (A) - N/A if it is below 0</returns>
        static string ConvertGradeToLetterGrade(double anyVariableNameWeWantThisBelongsToThisMethod)
        //naming convention for C# for a method - capitalize the first letter of each word
        {
            string letterGrade;
            if (anyVariableNameWeWantThisBelongsToThisMethod >= 90)
            {
                letterGrade = "A";

            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 80)
            {
                letterGrade = "B";
            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 70)
            {
                letterGrade = "C";

            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 60)
            {
                letterGrade = "D";

            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 0)
            {
                letterGrade = "F";

            }
            else
            {
                letterGrade = "N/A";
            }
            return letterGrade;
        }
    }
}
