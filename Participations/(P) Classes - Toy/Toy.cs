using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Toy
{
    public class Toy
    {
//ADDING PROPERTIES____________________________________________________________________________
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes; 

//ADDING METHODS___________________________________________________________________________
        //This is our constructor
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;

        }

        public Toy(string notes)
        {
            Notes = notes;
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            

        }

        public string GetAisle()
        {
            string aisle = "";
            Random rand = new Random();
            aisle = Manufacturer.ToUpper()[0].ToString() + rand.Next(1,25);
            //char FirstLetter = Manufacturer.ToUpper()[0];
            //Random rand = new Random();
            //int randomnumber = rand.Next(1,24);
            //string LetterNumber = FirstLetter + randomnumber.ToString();
            //return LetterNumber;
            return aisle;
        }
    }
}
 