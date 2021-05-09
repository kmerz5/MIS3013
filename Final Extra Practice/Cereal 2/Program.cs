using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Reading in the data file into the program
            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            //creating the list that will hold the information from the dataset
            List<Cereal> FileLines = new List<Cereal>();

            //For each line in the data set this will split it at the | 
            //For each line in the data set also set all the properties to the placement in
                //the dataset and do it for each line in the dataset
            //Then add all that new information to the list
            for (int i = 1; i < lines.Length; i++)
            {
                //setting a new variable called 'line' to the value of 'lines'(the variable the
                    //dataset was read in as at [i] so it will go through each line of the 
                    //dataset. 
                string line = lines[i];
                
                //split at the | to be able to read the data set
                string[] CerealInformation = line.Split("|");

                //creating the new instance of the class Cereal()
                Cereal c = new Cereal();
                c.Manufacturer = CerealInformation[0];
                c.Name = CerealInformation[1];
                c.Calories = Convert.ToDouble(CerealInformation[2]);
                c.Cups = Convert.ToDouble(CerealInformation[3]);

                //Adding that new instance to the list
                FileLines.Add(c);
            }

            Console.WriteLine("Cereals where the serving size is 1 cup or more:");
            Console.WriteLine(" ");
            //Output all the cereal information for the ones with a serving size
            //that is 1 cup or more
            foreach (Cereal cerealbowl in FileLines)
            {
                if (cerealbowl.Cups >= 1)
                {
                    Console.WriteLine(cerealbowl);

                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("Cereals where the serving is less than or equal to 100 calories:");
            Console.WriteLine(" ");
            //Output all the cereal information for the ones that have 100
            //calories or less per serving
            foreach (Cereal cb in FileLines)
            {
                if (cb.Calories <= 100)
                {
                    Console.WriteLine(cb);

                }

            }
        }
    }
}
