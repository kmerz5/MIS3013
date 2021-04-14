using System;

namespace _P__Classes___Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy("Good for children under the age of 10.");
            toy1.Manufacturer = "disney";
            toy1.Name = "Princess";
            toy1.Price = 24.00;

            string sentence = toy1.GetAisle();
            Console.WriteLine($"Toy 1: {sentence} ");
        }
    }
}
