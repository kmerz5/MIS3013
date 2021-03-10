using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Time to burn calories
                Create a C# console application (do not create a .NET CORE project) and name the project TimeToBurn.
            Running on a particular treadmill, you burn 3.9 calories per minute.  
            Ask the user how many calories they wish to burn in this workout session (this is their goal). DONE
            
            Once they tell you, output on the console after each minute, how many calories they have burned 
            (e.g. After 1 minute, you have burned 3.9 calories).  Keep outputting the total amount of calories 
            they have burned until they have met their goal.*/



            /*Console.WriteLine("How many calories do you wish to burn in this workout session?");
            string answer = Console.ReadLine();
            double goal = Convert.ToDouble(answer);

            double CaloriesPerMinute = 3.9;
            double minutes = 0;
            double CaloriesBurned = CaloriesPerMinute * minutes;

            while (CaloriesBurned < goal)
            {
                minutes++;
                CaloriesBurned = CaloriesBurned + CaloriesPerMinute;
                Console.WriteLine("After " + minutes + " minutes, you burned " + CaloriesBurned + " calories.");
            }*/


//-------------------------------------------------------------------------------------------------------------------
            /*Tutor
                Create a C# console application (do not create a .NET CORE project) and name the project Tutor. 
            Generate two random integers, each between 1 and 50, that you will be adding together to test the users
            ability to perform the addition operator.  Display the numbers in the console, such as:
            7 + 22 = ?DONE
            Once the user provides their answer, check to see if it is correct and if not, tell them sorry,
            please try again.  If their answer is correct, congratulate them on getting the right answer. 


            Random rand = new Random();
            int rand1 = rand.Next(1, 51);
            int rand2 = rand.Next(1, 51);
            int Sum = rand1 + rand2;
            int answer;
            do
            {
              Console.WriteLine(rand1 + " + " + rand2 + " = ?");
              string UserAnswer = Console.ReadLine();
              
                if (int.TryParse(UserAnswer, out answer)==false)
                {
                    Console.WriteLine("That was not a valid input. Goodbye.");
                    Environment.Exit(-1);
                }
                if (answer != Sum)
                {
                    Console.WriteLine("Sorry, that was incorrect, guess again.");
                    
                }
            } while (answer != Sum );
            Console.WriteLine("Congradulations! You got it right!"); */
            

           
     //-----------------------------------------------------------------------------------------------------------

            /*Tuition Increase
                Create a C# console application (do not create a .NET CORE project) and name the project 
            TuitionIncrease. The college charges a full-time student $12,000 in tuition per semester. 
            It has been announced that there will be a tuition increase by 5% each year for the next 7 years.  
            Your application should display the projected semester tuition amount for the next 7 years in the
            console window in the following format: The tuition after year 1 will be $12,600.
            Note: The number is in the output and the format of the tuition amount is currency with 0 decimal places*/

            double StartingTuition = 12600;
            double Tuition = 0;
            double TuitionIncrease = .05;
            

            for (int i = 1; i < 8; i++)
            {
                Tuition = StartingTuition + (Tuition * TuitionIncrease);
                Console.WriteLine("For year " + i + " the tuition is " + Tuition.ToString("C2"));
            }
            


        }
}
}
