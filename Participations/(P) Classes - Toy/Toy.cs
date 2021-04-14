using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Toy
{
    class Toy
    {
//ADDING PROPERTIES____________________________________________________________________________
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes; 

//ADDING METHODS___________________________________________________________________________
        public Toy()
        {
            Manufacturer = "Gerber";
            Name = "Kylie Merz";
            Price = 20.00;
            Notes = " ";

        }

        public string GetAisle()
        {
            char FirstLetter = Manufacturer.ToUpper()[0];
            Random rand = new Random();
            int randomnumber = rand.Next(1,24);
            string LetterNumber = FirstLetter + randomnumber.ToString();
            return LetterNumber;
        }
    }
}
 