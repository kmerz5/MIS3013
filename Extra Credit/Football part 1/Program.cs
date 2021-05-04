using System;

namespace Football_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserGuess;
            Console.WriteLine("How many touchdowns do you think the Dallas Cowboys will score in their game against the Arizona Cardinals?");
            string answer = Console.ReadLine();
            UserGuess = Convert.ToInt32(answer);
            

            Random rand = new Random();
            int touchdowns = rand.Next(0, 10);

            while(UserGuess != touchdowns)
            {
                Console.WriteLine("Sorry! Guess Again!");
                answer = Console.ReadLine();
                UserGuess = Convert.ToInt32(answer);
                

            }

            Console.WriteLine(" ");
            Console.WriteLine($"Congrats, you got it right! The Dallas Cowboys scored {touchdowns} in their game against the Arizona Cardinals!");

            Console.WriteLine(" ");
            Console.WriteLine("Please choose a color (red, blue, green, or black). We will show you which teams use that color in their team colors.");
            string teamcolor = Console.ReadLine();
            string Output = TeamColor(teamcolor);
        }

        static string TeamColor(string teamcolor)
        {
            if (teamcolor.ToLower() == "red")
            {
                Console.WriteLine("The teams that use red in their team colors are: The Buffalo Bills, Houston Texans, and Kansas City Chiefs.");

            }
            else if (teamcolor.ToLower() == "blue")
            {
                Console.WriteLine("The teams that use blue in their team colors are: The Dallas Cowboys, Miami Dolphins, New England Patriots, Indianapolis Colts, Tennessee Titans, Denver Broncos, and Los Angeles Chargers. ");

            }
            else if (teamcolor.ToLower() == "green")
            {
                Console.WriteLine("The teams that use green in their team colors are: the New York Jets, Philadelphia Eagles, and Green Bay Packers. ");

            }
            else if (teamcolor.ToLower() == "black")
            {
                Console.WriteLine("The teams that use black in their team colors are: The New Orleans Saints, Carolina Panthers, Atlanta Falcons, and Pittsburgh Steelers.");

            }
            else
            {
                Console.WriteLine("Sorry, that color was not one of the choices. Goodbye!");
                Environment.Exit(1);
            }
            return teamcolor;
        }
    }
}
