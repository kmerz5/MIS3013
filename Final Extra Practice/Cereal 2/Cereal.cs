using System;
using System.Collections.Generic;
using System.Text;

namespace Cereal_2
{
   public class Cereal
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }



        //empty constructor
        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0.0;
            Cups = 0.0;

        }

        public override string ToString()
        {
            return $"This cereal is made by: {Manufacturer} and is called, {Name}. This cereal contains {Calories} and has {Cups} cup(s) per serving.";
        }
    }
    
}
