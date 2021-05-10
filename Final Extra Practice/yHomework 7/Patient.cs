using System;
using System.Collections.Generic;
using System.Text;

namespace yHomework_7
{
   public class Patient
    {
        //properties
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights { get; set; }
        public List<string> AppointmentHistory { get; set; }

        //constructors
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

        public Patient(string firstName, char midInit, string lastName)
        {
            FirstName = firstName;
            MidInitial = midInit;
            LastName = lastName;
            ID = 0;
            FluVaccineYN = false;
           Weights =  new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
        }

        public override string ToString()
        {
            string output = $"{LastName},{FirstName} {MidInitial}. ({ID}) Flu Vaccine: ";
            if (FluVaccineYN)
            {
                output += "yes";

            }
            else
            {
                output += "no";
            }
            return output; 
        }

        public double CalculateMaxWeight()
        {
            double maxweight = -50;
            foreach (double weight in Weights.Values)
            {
                if (weight > maxweight)
                {
                    maxweight = weight;

                }

            }
            return maxweight;
        }

        public void DisplayApptHist()
        {
            foreach (string appointment in AppointmentHistory)
            {
                Console.WriteLine($"{appointment}");
            }
        }

        public void AdministerVaccine()
        {
            if (FluVaccineYN)
            {
                Console.WriteLine("This patient has already received the flu vaccine.");

            }
            else
            {
                Console.WriteLine("This patient has now been administered the flu vaccine.");
                FluVaccineYN = true;
            }
        }
    }
}
