using System;
using System.Collections.Generic;
using System.Text;

namespace zHomework7
{
    public class Patient
    {
    //Properties
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights {get;set;}
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
            Weights = new Dictionary<DateTime, double>();
            AppointmentHistory = new List<string>();
        }

    //Override ToString()
        public override string ToString()
        {
            string output = $"{LastName}, {FirstName} {MidInitial}. ({ID}) Flu Vaccine: ";
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

    //CalculateMaxWeight Method
        public double CalculateMaxWeight()
        {
            double weight = -50;
            foreach (double weights in Weights.Values)
            {
                if (weights > weight)
                {
                    weight = weights;

                }


            }
            return weight;
        }

    //DisplayApptHist Method
        public void DisplayApptHist()
        {
            foreach (string appt in AppointmentHistory)
            {
                Console.WriteLine(appt);

            }
            
        }

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
