using System;
using System.Collections.Generic;
using System.IO;

namespace Classes___Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*We want to read in a data set of Cereal information and help answer a few questions for the user.  
             * The application should output all of the Cereal information that have a serving size that is 1 cup 
             * or more.  After you output all those cereals, we also need to inform them which Cereals have 100 
             * calories or less per serving.*/

            //data set that was input was separated by |

            //Read in dataset
            string[] lines = File.ReadAllLines("Cereal_Data (1).txt");

            //create a list to contain all the lines of the file
            List<Cereal> bowls = new List<Cereal>();

            //Go through the list and split at the | and add each column to each property of the class
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] CerealInformation = line.Split('|');

                Cereal c = new Cereal();
                c.Manufacturer = CerealInformation[0];
                c.Name = CerealInformation[1];
                c.Calories = Convert.ToDouble(CerealInformation[2]);
                c.Cups = Convert.ToDouble(CerealInformation[3]);

                bowls.Add(c);

            }

            //Outputting all the cereal information where the serving size is 1 cup
            Console.WriteLine("Here is all the cereal information for cereals which have a serving size less than 1 cup:");
            Console.WriteLine(" ");
            foreach (Cereal CerealBowls in bowls)
            {
                if (CerealBowls.Cups > 1)
                {
                    Console.WriteLine(CerealBowls);

                }

            }
            //outputting all the cereal information where the serving size has 100 calories or less
            Console.WriteLine(" ");
            Console.WriteLine("Here is all the cereal information for cereals which have 100 or less calories per serving:");
            Console.WriteLine(" ");
            foreach (Cereal CB in bowls)
            {
                if (CB.Calories <= 100)
                {
                    Console.WriteLine(CB);

                }

            }
        }
    }
}
