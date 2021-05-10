using System;

namespace yHomework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Patient p1 = new Patient();
            p1.FirstName = "Kylie";
            p1.MidInitial = 'E';
            p1.LastName = "Merz";
            p1.ID = 5;
            p1.FluVaccineYN = false;
            p1.Weights.Add(DateTime.Now, 120);
            p1.Weights.Add(DateTime.Now.AddDays(-145), 140);
            p1.AppointmentHistory.Add("Annual Checkup");
            p1.AppointmentHistory.Add("Sports Physical");

            Console.WriteLine(p1);
            p1.AdministerVaccine();
            Console.WriteLine(p1);
            Console.WriteLine($"Max Weight: {p1.CalculateMaxWeight()}");
            Console.WriteLine("Appointment History: ");
            p1.DisplayApptHist();
            
            
        }
    }
}
