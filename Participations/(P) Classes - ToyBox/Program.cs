using System;
using System.Collections.Generic;

namespace _P__Classes___ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<ToyBox> toyboxes = new List<ToyBox>();
            string UserAnswer;
            
               Console.WriteLine("Please add a toybox.");
                do
                {
                    ToyBox newToyBox = GetNewToyBoxFromUser();
                    toyboxes.Add(newToyBox);
                    Console.WriteLine("Do you want to add another toybox? yes or no>>");
                    UserAnswer = Console.ReadLine();

                } while (UserAnswer.ToLower() == "yes");

 
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

            Console.WriteLine("Time to take a look at all your toys!");
            Console.WriteLine();
            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"Content of {toyBox.Owner}'s ToyBox!");
                foreach (Toy toy in toyBox.Toys)
                {
                    Console.WriteLine(toy);


                }
                
                

            }

            foreach (ToyBox TB in toyboxes)
            {
                Console.WriteLine($"{TB.GetRandomToy()}");

            }
                

            

        }

        private static ToyBox GetNewToyBoxFromUser()
        {
            Console.WriteLine("Enter the location of the toybox.");
            string loc = Console.ReadLine();

            Console.WriteLine("Enter the owner of the toybox.");
            string owner = Console.ReadLine();

            ToyBox box = new ToyBox()
            {
                Location = loc,
                Owner = owner
            };
            return box;
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
