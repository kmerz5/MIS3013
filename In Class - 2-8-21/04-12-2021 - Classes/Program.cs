using System;

namespace _04_12_2021___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
     //create first instance of Rectangle - USING THE RECTANGLE CLASS WE CREATED
            Rectangle rect1 = new Rectangle();
            rect1.Length = 5;
            rect1.Width = 15;
            //if we forget to define these values then it will use the constructor and give 7 and 7
            double area = rect1.CalculateArea();

            Console.WriteLine($"Rectangle 1: W:{rect1.Width}, L:{rect1.Length}, A:{area}, P:{rect1.CalculatePerimiter()}");

     // create second instance of rectangle / using our Overload constructor so inputing the #'s into the new variable
            Rectangle rect2 = new Rectangle(25.5, 3.33);
            Console.WriteLine($"Rectangle 1: W:{rect2.Width}, L:{rect2.Length}, A:{rect2.CalculateArea()}, P:{rect2.CalculatePerimiter()}");

            //Rectangle is the class
            //rect1 & rect2 are the intances

//____________________________________________________________________________________________________

            //Create first instance of our circle
            Circle circ1 = new Circle();
            circ1.Radius = 3.33;
            Console.WriteLine($"Circle 1: R:{circ1.Radius}, A:{circ1.CalculateArea()}, P:{circ1.CalculatePerimiter()}");

            Circle circ2 = new Circle();
            circ2.Radius = 9.66;
            Console.WriteLine($"Circle 2: R:{circ2.Radius}, A:{circ2.CalculateArea()}, P:{circ2.CalculatePerimiter()}");
        }
    }
}
