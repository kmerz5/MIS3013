using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You are the manager of a college health center. You decide that it is a good idea to develop 
             * an online health portal where patients can view their information (test results, appointments, etc.).
             * Before you can progress the project, you need to identify which patient attributes your system will 
             * track and then create a model.*/

            Console.WriteLine("Patient 1:");
            Console.WriteLine(" ");
            Patient p1 = new Patient();
            p1.FirstName = "Kylie";
            p1.MidInitial = 'E';
            p1.LastName = "Merz";
            p1.ID = 5;
            p1.FluVaccineYN = false;
            p1.Weights.Add(DateTime.Now, 130);
            p1.Weights.Add(DateTime.Now.AddDays(-400),140);
            p1.AppointmentHistory.Add("Yearly Checkup");
            Console.WriteLine(p1);
            p1.AdministerVaccine();
            Console.WriteLine(p1);
            Console.WriteLine($"{p1.ToString()}, Max Weight: {p1.CalculateMaxWeight()}");

        }
    }
}
