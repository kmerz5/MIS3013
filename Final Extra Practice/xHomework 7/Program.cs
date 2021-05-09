using System;

namespace xHomework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patient 1:");
            Patient p1 = new Patient();
            p1.FirstName = "Kylie";
            p1.MidInitial = 'E';
            p1.LastName = "Merz";
            p1.ID = 5;
            p1.FluVaccineYN = false;
            p1.Weights.Add(DateTime.Now, 140);
            p1.Weights.Add(DateTime.Now.AddDays(-145), 150);
            p1.AppointmentHistory.Add("Yearly Checkup");
            p1.AppointmentHistory.Add("Sports Physical");

            Console.WriteLine(p1);
            p1.AdministerVaccine();
            Console.WriteLine(p1);
            Console.WriteLine("Appointment History:");
            Console.WriteLine($"{p1.ToString()}, Max Weight:{p1.CalculateMaxWeight()} ");


        }
    }
}
