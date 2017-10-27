using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Human Rick = new Human("Rick");
            Human Morty = new Human("Morty");

            Console.WriteLine(Morty.health);
            Rick.Attack(Morty);
            Console.WriteLine(Morty.health);
        }
    }
}
