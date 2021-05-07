using System;
using System.Collections.Generic;

namespace Final_Extra_Practice
{
    class Program
    {
        const double TAX_RATE = .0085;
        static void Main(string[] args)
        {
            /* Create a new Console Application, name the solution Homework 6 and the project CoffeeShop.
            You are the owner of a small coffee shop. In order to get more people to your website, you want to create a 
            “Coffee House Game” that website visitors can play. 

            DONE- The game will call the GetMenu method to display the menu, and then ask the user what they want to order.
            - Then, the application should call the Calculate Price method and the Display Receipt method. 
              when the receipt for that item has been displayed, 
            - the application should ask the user if they would like to order anything else. 
            - Once they say no, the application should output the total of everything the user has ordered. 
            - The application should also thank the user for playing before closing. */
            
            //create the list in order to keep track of what each person orders
            List<string> CustOrders = new List<string>();
            
            string answer;
            double total = 0;
            string UserAnswer;
            //output the menu for the user to look at
            string Output = GetMenu();
            Console.WriteLine(Output);
            do
            {
               
                //Ask them what they want to order from the menu
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to order from the menu? >>");
                answer = Console.ReadLine();

                //Add what they ordered to the list
                CustOrders.Add(answer);

                //calculate the price of what they ordered
                double price = CalculatePrice(answer);
                total += price; //this will work so that if they order multiple things it can add them together and start at 0

                //display the receipt
                ShowReceipt(price);

                //Ask if they want to order anything else
                Console.WriteLine("Would you like to order another item?");
                UserAnswer = Console.ReadLine();

            } while (UserAnswer.ToLower() == "yes");

            //going through the list to show what they ordered
            Console.WriteLine("You ordered: ");
            bool isFirstTime = true;
            foreach (string item in CustOrders)
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
        

        /// <summary>
        /// Created a message which contains the menu for the user
        /// </summary>
        /// <returns>The menu for the user</returns>
        static string GetMenu()
        {

            string msg = "          Coffee Shop Menu" +
                "\n      Fresh Coffee ------ $2.25" +
                "\n     Café au lait ------ $3.72" +
                "\n         Latte ------ $4.03" +
                "\n     Hot Chocolate ------ $3.51" +
                "\n     Pumpkin Spice ------ $7.30";
            

            return msg;


        }

        /// <summary>
        /// This method takes what the user is ordering from the menu and then calculates the price for that item
        /// </summary>
        /// <param name="answer"></param>
        /// <returns>price</returns>
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
                Console.WriteLine("Sorry, that item is not on our menu.");
                price = 0;
            }
            return price;
        }

       /// <summary>
       /// This method takes the price of the previous method and then will calculate the users total, tax, and subtotal
       /// </summary>
       /// <param name="price"></param>
       static void ShowReceipt(double price)
        {
            double tax = price * TAX_RATE;
            double subtotal = tax + price;
            Console.WriteLine($"The total for your purchase is {price.ToString("C2")}");
            Console.WriteLine($"The tax for your purchase is {tax.ToString("C2")}");
            Console.WriteLine($"The subtotal for your purchase is {subtotal.ToString("C2")}");

        }
    }
}
