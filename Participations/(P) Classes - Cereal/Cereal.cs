using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Cereal
{
   public class Cereal
    {
        //properties
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
            return $"{Name} madey by {Manufacturer} has a serving size of {Cups.ToString("N1")} and has {Calories.ToString("N1")} calories.";
        }

    }
}
