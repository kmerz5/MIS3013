using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message ="tAylOr SwIFT, the WeEkend, TraVis scoTT, ariana gRande, bIllie eIliSh";
            //OTHER WAY TO SOLVE THIS / this is hardcoding the values so it wont work for The Weekend
            string msg2 = "tAyLor SwiFt";

            //Help with participation putting the names vertically not horizontally
           // for (int i = 0; i < msg2.Length; i++)
           // {
               // Console.WriteLine(msg2[i]);
           // }

            
            
            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            //toupper and tolower are only for strings not characters
            Console.WriteLine(newMessage);

            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                int INDEXOFSPACE = msg2.IndexOf(' '); //LOOKING FOR A SPACE
                msg2 = msg2.ToUpper()[0] + msg2.ToLower().Substring(1, INDEXOFSPACE) + msg2.ToUpper()[INDEXOFSPACE + 1] + msg2.ToLower().Substring(INDEXOFSPACE + 2);
                Console.WriteLine(msg2);

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                string newArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1) + " " + lastName.ToUpper()[0] + lastName.ToLower().Substring(1);
                Console.WriteLine(newArtist);
                
            }
        }
    }
}
