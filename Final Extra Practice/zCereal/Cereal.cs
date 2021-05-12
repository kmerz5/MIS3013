using System;
using System.Collections.Generic;
using System.Text;

namespace zCereal
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
            return $"Manufacturer: {Manufacturer} | Name: {Name} | Calories per serving: {Calories} | Cups per Serving: {Cups}";
        }
    }
}
