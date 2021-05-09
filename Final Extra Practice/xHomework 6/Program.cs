using System;
using System.Collections.Generic;

namespace xHomework_6
{
    class Program
    {
        const double TAXRATE = .085;
        static void Main(string[] args)
        {
            /* Create a new Console Application, name the solution Homework 6 and the project CoffeeShop.
           You are the owner of a small coffee shop. In order to get more people to your website, you want to create a 
           “Coffee House Game” that website visitors can play. 

           - DONE The game will call the GetMenu method to display the menu, and then ask the user what they want to order.
           - Then, the application should call the Calculate Price method and the Display Receipt method. 
             when the receipt for that item has been displayed, 
           - the application should ask the user if they would like to order anything else. 
           - Once they say no, the application should output the total of everything the user has ordered. 
           - The application should also thank the user for playing before closing. */
            string answer;
            string UserAnswer;
            double total = 0;
            List<string> CustomerOrder = new List<string>();

            string output = GetMenu();
            Console.WriteLine(output);

            do
            {
                Console.WriteLine("What would you like to order from the menu?>>");
                answer = Console.ReadLine();
                CustomerOrder.Add(answer);

                double price = CalculatePrice(answer);
                Console.WriteLine($"Price: ${Convert.ToDouble(price)}");
                total += price;

                ShowReceipt(price);

                Console.WriteLine("Would you like to order something else?>>");
                UserAnswer = Console.ReadLine();
                

            } while (UserAnswer.ToLower() == "yes");

            
                //going through the list to show what they ordered
                Console.WriteLine("You ordered: ");
            bool isFirstTime = true;
            foreach (string item in CustomerOrder)
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
            Console.WriteLine();
            Console.WriteLine("Your total comes out to be " + total.ToString("C2"));
            Console.WriteLine(" ");
            Console.WriteLine("Thank you for playing!");
        }

        //Get Menu Method (display the menu)
        static string GetMenu()
        {
            string output = "      Coffee Shop Menu" +

                    "\n Fresh Coffee ------ $2.25" +

                    " \n Café au lait------ $3.72" +

                        " \n Latte------ $4.03" +

                    "\n Hot Chocolate ------ $3.51" +

                    "\n Pumpkin Spice ------ $7.30";

            return output;
        }

        //Calculate Price method
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
                Console.WriteLine($" Sorry, {answer} is not on our menu");
            }
            return price;

        }

        //Receipt Method

        static void ShowReceipt(double price)
        {
            double tax = price * TAXRATE;
            double subtotal = tax + price;

            Console.WriteLine($"Tax: {tax.ToString("C2")} | Subtotal: {subtotal.ToString("C2")}");
        }
    }
}
