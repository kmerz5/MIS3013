using System;
using System.Collections.Generic;
using System.IO;

namespace zCereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            List<Cereal> bowls = new List<Cereal>();
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string []CerealInformation = line.Split("|");
                Cereal c = new Cereal();
                c.Manufacturer = CerealInformation[0];
                c.Name = CerealInformation[1];
                c.Calories = Convert.ToDouble(CerealInformation[2]);
                c.Cups = Convert.ToDouble(CerealInformation[3]);
                bowls.Add(c);
                

            }

            Console.WriteLine("Cereal information for cereals with a serving size of 1 cup or more:");
            Console.WriteLine(" ");
            //Cereals with serving size of 1 cup or more
            foreach (Cereal cup in bowls)
            {
                if (cup.Cups >= 1)
                {
                    Console.WriteLine(cup);

                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("Cereal information for cereals with 100 or less calories per serving:");
            Console.WriteLine(" ");
            //Cereals with 100 calories or less per serving
            foreach (Cereal cal in bowls)
            {
                if (cal.Calories <= 100)
                {
                    Console.WriteLine(cal);

                }

            }
        }
    }
}
