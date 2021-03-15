using System;
using System.Collections.Generic;

namespace _3_15_21_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
   //QUESTION 1 FROM POWERPOINT
      /*Create two parallel arrays.  The first will hold student id’s and the second will hold their 
       * overall GPA. Ask the user for one of the id’s that they want to see the GPA for and then output it.*/

      //NOTES
            //anytime using collections highly recommend making it plural
            //parallel = having the same size
            //Var will say figure out what the datatype is based on what is on the right side of the equal sign (when defining a variable)
            
            string[] studentIDs = new string[3];
            double[] studentGPAs = { 3.0, 4.0, 2.5 };

            studentIDs[0] = "1";
            studentIDs[1] = "2";
            studentIDs[2] = "3";

            foreach (string id in studentIDs)
            {
                Console.Write($"{id}\t");
            }
            Console.WriteLine();

            Console.WriteLine("Whose GPA do you want to see?>>");
            string searchID = Console.ReadLine();

            for (int i = 0; i < studentIDs.Length; i++)
            {
                string id = studentIDs[i];
                double gpa = studentGPAs[i];
                if (id == searchID)
                {
                    Console.WriteLine($"{id} - {gpa.ToString("N3")}");
                }
                
            }

            //PROBLEM 2 FROM POWERPOINT
            /*Create a dictionary that the key will be the student id and the value will be their GPA.
            * Ask the user if there is another student they want to add, make sure it doesn’t exist then add it
            * Ask them for a student id and output their GPA*/

            //NOTES
                //when the lightbulb pops up after typing the first part click the first one and it puts a using statement at the top
                //anytime there are parenthesis you are calling a method or a function

            Dictionary<string, double> students = new Dictionary<string, double>();
            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.5);

            Console.WriteLine("Do you want to add another student?>>");
            string answer =Console.ReadLine();

            if (answer.ToLower()[0] == 'y')
            {
                Console.WriteLine("What is the student's ID? >>");
                string ID = Console.ReadLine();

                Console.WriteLine("What is the students GPA? >>");
                double GPA = Convert.ToDouble(Console.ReadLine());
                //containskey is validating that it doesnt already exist
                if (students.ContainsKey(ID) == true)
                {
                    Console.WriteLine("Already contains that key, we will update the GPA for you!");
                    students[ID] = GPA;
                }
                else
                {
                    students.Add(ID, GPA);
                }
               

            }

            foreach (string ID in students.Keys)
            {
                Console.WriteLine(ID);
            }

            Console.WriteLine("Whose GPA do you want to see? >>");
            searchID = Console.ReadLine();

            if (students.ContainsKey(searchID) == true)
            {
                Console.WriteLine($"{searchID} - {students[searchID].ToString()}");
            }
            else
            {
                Console.WriteLine("That student id does not exist");
            }
            






        }
    }
}
