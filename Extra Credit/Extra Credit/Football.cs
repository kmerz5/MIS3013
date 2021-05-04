using System;
using System.Collections.Generic;
using System.Text;

namespace Extra_Credit
{
    public class Football
    {
        //properties
        public string Team { get; set;}
        public string Quarterback { get; set; }
        public string College { get; set; }
        public string Drafted { get; set; }

        //Empty Constructor
        public Football()
        {
            Team = string.Empty;
            Quarterback = string.Empty;
            College = string.Empty;
            Drafted = string.Empty;
        }

        

        //override string for the output
        public override string ToString()
        {
            return $"{Quarterback} plays for The {Team}. {Quarterback} attended college at The University of {College}, and was drafted in the year of {Drafted}";
        }
    }
}
