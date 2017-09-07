using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var foundPerson = from artist in Artists
                              where artist.Hometown == "Mount Vernon"
                              select new {artist.ArtistName, artist.Age};
            foreach (var person in foundPerson)
            {
                Console.WriteLine($"{person.ArtistName}");
            }

            //Who is the youngest artist in our collection of artists?
            var youngest = Artists.OrderBy(person => person.Age).Take(1);
            foreach (var person in youngest)
            {
                Console.WriteLine($"{person.ArtistName}");
            }

            //Display all artists with 'William' somewhere in their real name
            var allWilliams = Artists.Where(artist => artist.RealName.Contains("William"));
            foreach (var william in allWilliams)
            {
                Console.WriteLine($"{william.RealName}");
            }           

            //Display the 3 oldest artist from Atlanta
            var oldestAtlantans = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(artist => artist.Age).Take(3);
            foreach (var atlantan in oldestAtlantans)
            {
                Console.WriteLine($"{atlantan.ArtistName}");
            } 

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'

        }
    }
}
