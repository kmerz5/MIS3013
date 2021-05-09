using System;
using System.Collections.Generic;
using System.Text;

namespace xHomework_7
{
    public class Patient
    {
        //properties
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights {get; set;}
        public List<string> AppointmentHistory { get; set; }

    //Constructors
        //Empty Construstor
        public Patient()
        {
            FirstName = string.Empty;
            MidInitial = ' ';
            LastName = string.Empty;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();

        }

        //int PatID constructor
        public Patient(int patID)
        {
            FirstName = string.Empty;
            MidInitial = ' ';
            LastName = string.Empty;
            ID = patID;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();

        }

        //firstname, middel initial and last name constructor
        public Patient(string firstName, char midInit, string lastName)
        {
            FirstName = firstName;
            MidInitial = midInit;
            LastName = lastName ;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();

        }

    //Methods
        //Override to String
        public override string ToString()
        {
            string Output =  $"{LastName}, {FirstName}, {MidInitial}. ID({ID}) Flu Vaccine:  ";
            if (FluVaccineYN)
            {
                Output += "Yes";

            }
            else
            {
                Output += "No"; 
            }

            return Output;
        }

        //Calculate Max Weight
        public double CalculateMaxWeight()
        {
            double maxweight = -50;
            foreach (double max in Weights.Values)
            {
                if (maxweight <= max)
                {
                    maxweight = max;
                }

            }
            return maxweight;

        }

        //Display appoint history
        public void DisplayApptHist()
        {
            foreach (string history in AppointmentHistory)
            {

                Console.WriteLine(history);
            }
        }

        //AdministerVaccine
        public void AdministerVaccine()
        {
            if (FluVaccineYN)
            {
                Console.WriteLine("This patient has already received the vaccine.");

            }
            else
            {
                Console.WriteLine("This patient has now been administered the vaccine.");
                FluVaccineYN = true;
            }
        }
       


    }
}
