using System;
using System.Collections.Generic;
using System.IO;

namespace yCereal
{
    class Program
    {
        static void Main(string[] args)
        {
            //read in the file
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //Create a list for all of the lines in the data set to go into
            List<Cereal> bowls = new List<Cereal>();//MAKE SURE TO PUT THE <CEREAL> NOT STRING - this is because it is accepting the values from the class Cereal
            //go through all the lines in the data set and add them to the list
            for (int i = 1; i < lines.Length; i++)
            {
                string cerealinformation = lines[i];
                string [] CI = cerealinformation.Split('|'); //FORGOT THE [] YOU NEED THIS this means that its an array

                Cereal c = new Cereal();
                c.Manufacturer = CI[0];
                c.Name = CI[1];
                c.Calories = Convert.ToDouble(CI[2]);
                c.Cups = Convert.ToDouble(CI[3]);

                bowls.Add(c);


            }

            Console.WriteLine(" ");
            Console.WriteLine("The cereal information for cereals with 1 cup or more for serving size:");
            Console.WriteLine(" ");
            //output all cereal info with serviing size being 1 cup or more
            foreach (Cereal cerealbowl in bowls)
            {
                if (cerealbowl.Cups >= 1)
                {
                    Console.WriteLine(cerealbowl);

                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("The cereal information for cereals with 100 or less calories per serving:");
            Console.WriteLine(" ");
            //output all cereal info with 100 or less calories per serving
            foreach (Cereal servings in bowls)
            {
                if (servings.Calories <= 100)
                {
                    Console.WriteLine(servings);

                }

            }
        }
    }
}
