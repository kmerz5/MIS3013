using System;
using System.Collections.Generic;
using System.IO;

namespace Extra_Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Football DataSet.csv");
            //              0       1            2       3
            //Lines[0] = "team, quarterback, college, drafted"
            //The CSV is seperated by commas

            //Creating the List with all the information
            List<Football> TeamInfo = new List<Football>();

            //Adding all the information from the CSV to the list
            for (int i = 1; i < lines.Length; i++) //start at 1 bc we dont want the top labels
            {
                string line = lines[i];

                //no need to split because they are already split with ,

                string[] FootballInformation = line.Split(',');

                Football f = new Football();
                f.Team = FootballInformation[0];
                f.Quarterback = FootballInformation[1];
                f.College = FootballInformation[2];
                f.Drafted = FootballInformation[3];

                TeamInfo.Add(f);

            }

            //Output all the football information for players who attended the university of Oklahoma
            Console.WriteLine("List of NFL player information for players who graduated from The University of Oklahoma:");
            Console.WriteLine(" ");
            foreach (Football college in TeamInfo)
            {
                if (college.College == "Oklahoma")
                {
                    Console.WriteLine(college);

                }

            }

            //Output all the football information for players who were drafted in 2018
            Console.WriteLine(" ");
            Console.WriteLine("NFL player information for players who were drafted in the year of 2018:");
            Console.WriteLine(" ");
            foreach (Football drafted in TeamInfo)
            {
                if (drafted.Drafted == "2018")
                {
                    Console.WriteLine(drafted);

                }

            }

        }
    }
}
