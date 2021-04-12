using System;
using System.Collections.Generic;
using System.Text;

namespace _04_12_2021___Classes
{//To add the class right click the project and add class then name according to UML then add public infront of word class
    public class Rectangle
    {
      
 //ADD OUR PROPERTIES/ATTRIBUTES (+ = PUBLIC / -= PRIVATE)
            //public double _Length; //public is letting the whole world have access to it
           // public double GetLength()
          //  return _Length;
          //}

        //public void SetLength(double length)
        //{
           // _Length = length;
        //}
        //private double Width;

     //THIS BELOW CREATES ALL OF WHAT IS ABOVE BEHIND THE SCENES
        public double Length { get; set; }
        public double Width { get; set; }

        //Then you can access this class from the Program.cs after defining them here

//ADDING IN OUR METHODS
     //constructor - the default / if we dont put anything inside our class we get this method for free but we dont see it on our screen
        //ctor and tab twice it will create the constructor for you
        //giving the values we defined above a starting value
        public Rectangle()
        {
            Length = 7;
            Width = 7;

        }
        public Rectangle(double length, double width) //do the lowercase NOT uppercase so it can be empty
        {
            //create a new rectange, but dont do the defaults bc I know the length and width that I want
            Length = length;
            Width = width; //OR this.Width = Width; (if above double width is double Width

        }


    }
}
