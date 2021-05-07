using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
   public class Patient
    {
        //Properties
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights { get; set; }
        public List<string> AppointmentHistory { get; set; }


     //Methods

        //Empty Constructor
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

        //Constructor but that passes through int patID
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

        //Constructor that passes through firstname, midinitial, and lastname
        public Patient(string firstName, char midInit, string lastName)
        {
            FirstName = firstName;
            MidInitial = midInit;
            LastName = lastName;
            ID = 0;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();

        }

        //To String
        public override string ToString()
        {
            string toOutPut = $"{LastName}, {FirstName}, {MidInitial}. ({ID}), Flue Vaccine: ";
            if (FluVaccineYN)
            {
                toOutPut += "Yes";

            }
            else
            {
                toOutPut += "No";
            }
            return toOutPut;
        }

        public double CalculateMaxWeight()
        {
            double maxweight = -50;
            foreach (double weight in Weights.Values)
            {
                if (maxweight <= weight)
                {
                    maxweight = weight;
                }

            }
            return maxweight;
        }

        public void DisplayAppt()
        {
            foreach (string appointment in AppointmentHistory)
            {
                Console.WriteLine(appointment);

            }
        }

        public void AdministerVaccine()
        {
            if (FluVaccineYN)
            {
                Console.WriteLine("This patient has already had the vaccine.");

            }
            else
            {
                Console.WriteLine("The patient has now been administered the vaccine.");
                FluVaccineYN = true;
            }
        }

    }
}
