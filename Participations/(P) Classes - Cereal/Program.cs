using System;
using System.Collections.Generic;
using System.IO;

namespace _P__Classes___Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The application should output all of the Cereal information that have a serving size that is 1 
             * cup or more. After you output all those cereals, we also need to inform them which Cereals have 100 
             * calories or less per serving.*/


            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //              0       1           2      3
            //lines[0] = "name|manufacturer|calories|cups";

            List<Cereal> bowls = new List<Cereal>();

            
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                //line = "100% Bran | Nabisco | 70|.33"

                string[] cerealInformation = line.Split('|');
                //CerealInformation = {"100% Bran","Nabisco","70","0.33"}

                string name = cerealInformation[0];
                Cereal c = new Cereal();
                c.Name = name;
                c.Manufacturer = cerealInformation[1];
                c.Calories = Convert.ToDouble(cerealInformation[2]);
                c.Cups = Convert.ToDouble(cerealInformation[3]);

                bowls.Add(c);
                

            }

            Console.WriteLine("List of cereal information for cereals that have 1 or more cups per serving:");
            Console.WriteLine(" ");
            foreach (Cereal cereal in bowls)
            {
               
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal);

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("List of cereal information for cereals that have 100 or less calories per serving:");
            Console.WriteLine(" ");
            foreach (Cereal cereal in bowls)
            {
                if (cereal.Calories <=100)
                {
                    Console.WriteLine(cereal);

                }

            }
            


           
        }
    }
}
