using System;
using System.Collections.Generic;

namespace _P__Classes___Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> ToyBox = new List<Toy>();

            Toy toy1 = new Toy("For ages 5+");
            toy1.Manufacturer = "disney";
            toy1.Name = "Princess";
            toy1.Price = 24.00;
            ToyBox.Add(toy1);
            
            

            string sentence = toy1.Name + " is mannufactured by " + toy1.Manufacturer + " and costs, " + toy1.Price.ToString("C2");
            Console.WriteLine($"Toy 1: {sentence} ");

            Toy toy2 = new Toy("Do not eat");
            toy2.Name = "bubbles";
            toy2.Manufacturer = "Bubble Company";
            toy2.Price = 4.99;
            ToyBox.Add(toy2);

            sentence = toy2.Name + " is mannufactured by " + toy2.Manufacturer + " and costs, " + toy2.Price.ToString("C2");
            Console.WriteLine($"Toy 2: {sentence} ");

            //Outputting toys that are only from Disney
            foreach (Toy toy in ToyBox)
            {
                if (toy.Manufacturer.ToLower() == "disney")
                {
                    Console.WriteLine(toy);

                }

            }

        }
    }
}
