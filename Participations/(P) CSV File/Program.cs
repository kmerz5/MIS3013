using System;
using System.IO;

namespace _P__CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a Console application that will read (File.ReadAllLines) in the 
             * sales_data_sample.csv .  We want to sum up all of the sales with the status 
             * of Shipped and output the total sales by year (e.g. how much did we sell in 
             * 2003, 2004, 2005) as well as total sales by month across all years (e.g. how
             * much did we sell in January of 2003/2004/2005 and February of 2003/2004/2005
             * etc.), make sure to output it as January/February etc and not 1/2.*/


         //To read in the file we are going to call a function
         //To add the file right click - click add file - click the file - then properties
         //change to add always

            string[] lines = File.ReadAllLines("sales_data_sample.csv");

            double totalFor2003 = 0;
            double totalFor2004 = 0;
            double totalFor2005 = 0;
        //now we have every line of that file that we put in an array called lines

         //need to iterate through each line of this file
         //ORDERNUMBER	QUANTITYORDERED	PRICEEACH	ORDERLINENUMBER	SALES	ORDERDATE	STATUS	QTR_ID	MONTH_ID	YEAR_ID	PRODUCTLINE	MSRP	PRODUCTCODE	CUSTOMERNAME	PHONE	ADDRESSLINE1	ADDRESSLINE2	CITY	STATE	POSTALCODE	COUNTRY	TERRITORY	CONTACTLASTNAME	CONTACTFIRSTNAME	DEALSIZE

         //column called status at index 6 - datatype = string
         //column called sales at index 4 - datatype = double

         //Use a for loop to start at 1 instead of 0

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] pieces = line.Split(","); //[] because we are getting an array of strings back

                string status = pieces[6];
                int year = Convert.ToInt32(pieces[9]);
                int month = Convert.ToInt32(pieces[8]);
                double sales = Convert.ToDouble(pieces[4]); //sales exists in string line and after the 4th comma (split)

                if (pieces[6].ToLower() == "shipped")
                {
                    switch (year)
                    {
                        case 2003:
                            totalFor2003 += sales;
                            break;
                        case 2004:
                            totalFor2004 += sales;
                            break;
                        case 2005:
                            totalFor2005 += sales;
                            break;
                        default:
                            break;
                    }
                }

                

            }

        }
    }
}
