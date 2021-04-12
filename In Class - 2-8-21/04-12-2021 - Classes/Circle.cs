using System;
using System.Collections.Generic;
using System.Text;

namespace _04_12_2021___Classes
{
   //creating the class right click project and hit add class then name
    public class Circle
    {
    //creating the data names and types
        public double Radius { get; set; }

    //methods
        //constructor - setting to a starting value
         public Circle()
        {
            Radius = 0;
        }

        /// <summary>
        /// Calculate the area of the circle instance
        /// </summary>
        /// <returns>The area of the cirle</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Calculate the perimiter of the circle instance
        /// </summary>
        /// <returns>The perimiter of the circle</returns>
        public double CalculatePerimiter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
