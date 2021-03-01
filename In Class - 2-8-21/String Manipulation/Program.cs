using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message ="tAylOr SwIFT, the WeEkend, TraVis scoTT, ariana gRande, bIllie eIliSh";
            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            //toupper and tolower are only for strings not characters
            Console.WriteLine(newMessage);

            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                string newArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1) + " " + lastName.ToUpper()[0] + lastName.ToLower().Substring(1);
                Console.WriteLine(newArtist);
                
            }
        }
    }
}
