using System;
using System.Collections.Generic;

namespace zHomework6
{
    class Program
    {
        const double TAXRATE = .085;
        static void Main(string[] args)
        {
            string answer;
            string UserAnswer;
            double price;
            double total = 0;
            List<double> UserOrder = new List<double>();

            Console.WriteLine(GetMenu());
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to order from the menu?>>");
                answer = Console.ReadLine();
                

                price = CalculatePrice(answer);
                UserOrder.Add(price);
                ShowReceipt(price);

                Console.WriteLine("Would you like to order anything else?>>");
                UserAnswer = Console.ReadLine();

            } while (UserAnswer.ToLower() == "yes");

            foreach (double item in UserOrder)
            {
                total += price;

            }
            Console.WriteLine($"Your total for everything is: {total.ToString("C2")}");

        }

        //GetMenu Method
        static string GetMenu()
        {
            string output = "          Coffee Shop Menu" +
                "\n      Fresh Coffee ----- $2.25" +
                "\n      Cafe au lait ----- $3.72" +
                "\n         Latte ----- $4.03" +
                "\n      Hot Chocolate ----- $3.51" +
                "\n      Pumpkin Spice ----- $7.30";
            return output;
        }

        //CalculatePrice Method
        static double CalculatePrice(string answer)
        {
            double price;
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
                Console.WriteLine("Sorry, that item is not on our menu.");
                price = 0.0;
            }

            return price;

        }

        //ShowReceipt method
        static void ShowReceipt(double price)
        {
            double tax = price * TAXRATE;
            double subtotal = price + tax;

            Console.WriteLine($"Price: {price.ToString("C2")} | Tax: {tax.ToString("C2")} | Subtotal: {subtotal.ToString("C2")}");
        }
    }
}
