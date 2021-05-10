using System;
using System.Collections.Generic;

namespace yHomework6
{
    
    class Program
    {
        const double TAXRATE = .085;
        static void Main(string[] args)
        {
            //a list to hold all of the order information
            List<string> Order = new List<string>();
            string answer;
            string UserAnswer;
            double total = 0;
            Console.WriteLine(GetMenu());
            Console.WriteLine(" ");
            

            do
            {
                //get their order and add it to the list
                Console.WriteLine("What would you like to order from the menu?");
                answer = Console.ReadLine();
                Order.Add(answer);

                double price = CalculatePrice(answer);
                CalculatePrice(answer);
                ShowReceipt(price);

                total += price;

                
                Console.WriteLine("Would you like to order something else from the menu?");
                UserAnswer = Console.ReadLine();

            } while (UserAnswer.ToLower() == "yes");

            Console.WriteLine("You ordered: ");
            bool isFirstTime = true;
            foreach (string item in Order)
            {
                if (isFirstTime)
                {
                    Console.Write(item);
                    isFirstTime = false;
                }
                else
                {
                    Console.Write(", " + item);
                }
            }
            Console.WriteLine($" Total of all Ordered: {total.ToString("C2")}");
            Console.WriteLine("Thank you for playing!");


        }

        static string GetMenu()
        {
            string output = "          Coffee Shop Menu" +
                "\n      Fresh Coffee ----- $2.25" +
                "\n      Cafe au lait ----- $3.72" +
                "\n          Latte ----- $4.03" +
                "\n      Hot Chocolate ------ $3.51" +
                "\n      Pumpkin Spice ----- $7.30";
            return output;
        }

        static double CalculatePrice(string answer)
        {
            double price = 0;
            if (answer.ToLower() == "fresh coffee")
            {
                price = 2.25;
                

            }
            else if (answer.ToLower() == "cafe au lait")
            {
                price = 3.72;

            }
            else if (answer.ToLower() == "latte")
            {
                price = 4.03;

            }
            else if (answer.ToLower() == "hot chocolate")
            {
                price = 3.51;

            }
            else if (answer.ToLower() == "pumpkin spice")
            {
                price = 7.30;

            }
            else
            {
                Console.WriteLine("Sorry that item is not on our menu.");
                price = 0;
            }

            return price;
        }

        static void ShowReceipt(double price)
        {
            
            double tax = price * TAXRATE;
            double subtotal = price + tax;
            double total = price;
            Console.WriteLine($"Item Price: {price.ToString("C2")} | Tax: {tax.ToString("C2")} | Subtotal: {subtotal.ToString("C2")}");
            
        }
    }
}
