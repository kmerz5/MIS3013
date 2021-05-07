using System;
using System.Collections.Generic;
using System.Text;

namespace Classes___Cereal
{
    public class Cereal
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }

        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0.0;
            Cups = 0.0;

        }

        public override string ToString()
        {
            return $"{Name} made by {Manufacturer} contains {Calories.ToString("N1")} calories per serving and {Cups.ToString("N1")} cups per serving.";
        }
    }

}
