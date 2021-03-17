using System;
using System.Collections.Generic;
using System.IO;

namespace Z_Read_in_a_File_3_17_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NOTES
                 - CSV means comma seperated values
                 - downloading the file - then click open with notepad
                 - if reading in a file on an exam he will give it to us
                  - right click the project click add existing file / change to all files
                 - then click the file you want to add
                 - Properties tab and click and COPY ALWAYS  - something with properties square on the right*/

            //read it in line by line
            string[] lines = File.ReadAllLines("geoMap.csv");
            List<string> states = new List<string>();
            List<double> soccerscores = new List<double>();
            List<double> footballscores = new List<double>();

            for (int i = 3; i < lines.Length; i++)
            {
                //"North Dakota,12%,88% - what string looks like so we need to split on the comma
                string line = lines[i];
                //        0          1      2
                //{"North Dakota", "12%", "88%"} - will give us back an array that looks like this
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);

                //"12%" - need to get rid of the percent
                string soccerscoreAsString = pieces[1];
                double soccerscore = Convert.ToDouble(soccerscoreAsString.Trim('%')) / 100;
                soccerscores.Add(soccerscore);

                footballscores.Add(Convert.ToDouble(pieces[2].Trim('%')) / 100);

                
            }

            for (int i = 0; i < footballscores.Count; i++)
            {
                if (soccerscores[i] > footballscores[i])
                {
                    Console.WriteLine(states[i]);

                }

            }

             


        }
    }
}
