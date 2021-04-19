using System;
using System.Collections.Generic;

namespace _P__Classes___ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //put these into a collection
            //need to keep asking the user if they want to add more toyboxes(make a look getting the information for the toybox 
            //then ask if they have another toybox to add.
            ToyBox TB1 = new ToyBox()
            {
                Location = "Andy's Bedroom",
                Owner = "Andy"
            };
            ToyBox TB2 = new ToyBox()
            {
                Location = "Anna's Bedroom",
                Owner = "Anna"
            };

            List<ToyBox> toyboxes = new List<ToyBox>();

            string answer;

            
                foreach (ToyBox toyBox in toyboxes)
                {
                Console.WriteLine($"Time to fill {toyBox.Owner}'s Toy Box!");
                do
                    {
                        

                    Toy newToy = GetNewToyFromUser();
                    toyBox.Toys.Add(newToy);

                        Console.WriteLine("do you want to enter another toy? yes or no?>>");
                        answer = Console.ReadLine();

                    } while (answer.ToLower() == "yes");
                    

                }

            Console.WriteLine("time to take a look at all your toys!");
            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"Content of {toyBox.Owner}'s ToyBox!");
                foreach (Toy toy in toyBox.Toys)
                {
                    Console.WriteLine(toy);

                }

            }
                

            

        }

        private static Toy GetNewToyFromUser()
        {
            Console.WriteLine("Enter the Manufacturer of the toy >>");
            string manu = Console.ReadLine();

            Console.WriteLine("Enter the price of the toy >>");
            double pri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the name of the toy >>");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the notes for the toy >>");
            string note = Console.ReadLine();

            Toy toy = new Toy()
            {
                Manufacturer = manu,
                Price = pri,
                Name = name
            };
            toy.AddNote(note);

            return toy;
        }
    }
}
