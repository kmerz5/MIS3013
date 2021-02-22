using System;

namespace _2_22_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //DO WHILE LOOP WITH BANANA AND ORANGE JOKE
            //String usersAnswer = "";

            // do
            //{
            // Console.WriteLine("knock knock. Who's there? >>");
            // usersAnswer = Console.ReadLine();

            //} while (usersAnswer.ToLower() !="banana");


            //THIS IS THE WHILE LOOP CONVERTED TO A DO WHILE ABOVE
            //Console.WriteLine("Knock Knock. Who's there? >>");
            //usersAnswer = Console.ReadLine();

            //while (usersAnswer.ToLower() !="banana")
            //{
            // Console.WriteLine("knock knock. Who's there? >>");
            //usersAnswer = Console.ReadLine();
            //}


            //All the multiples of 3 up to 1000 - USE A FOR LOOP BECAUSE WE DONT KNOW EXACTLY HOW MANY ITERATIONS WE NEED
            //for (int i = 1; i <= 1000; i++)
            //{
            // if (i % 3 == 0)
            //{
            //Console.WriteLine($"{i} is a multiple of 3");

            //}


            //WHILE LOOP EXAMPLE DOING THE SAME AS ABOVE   
            // int i = 3;
            //while (i <= 1000)
            //{
            //Console.WriteLine(i);
            //i += 3;
            //}


//ASK THEM FOR FAVORITE NUMBER, IF THEY DONT GIVE AN INTEGER, SEND THAT MESSAGE AND THEN ASK THE QUESTION AGAIN.
            int favoritenumber;
            Console.WriteLine("What's your favorite number? >>");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out favoritenumber) == false)
            {
                Console.WriteLine("incorrect value. you must enter an integer");
                answer = Console.ReadLine();
            }
            }
        }
    }

