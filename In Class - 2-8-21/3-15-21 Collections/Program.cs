using System;

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


        }
    }
}
