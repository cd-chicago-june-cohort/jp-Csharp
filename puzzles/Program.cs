using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {

        public static void RandomArray()
        {
            Random rand = new Random();
            int[] newArr = new int[10];
            int newRand = rand.Next(5, 25);
            newArr[0] = newRand;
            int min = newArr[0];
            int max = newArr[0];
            int sum = newArr[0];
            int i = 1;
            while (i < 10)
            {
                newRand = rand.Next(5, 25);
                newArr[i] = newRand;
                sum += newArr[i];
                if (newArr[i] > max)
                {
                    max = newArr[i];
                } 
                else if (newArr[i] < min)
                {
                    min = newArr[i];
                }
                i++;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
        }

        public static string CoinToss()
        {
            Console.WriteLine("Tossing a coin!");
            Random rand  = new Random();
            int toss = rand.Next(0, 1);
            if (toss == 0)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        public static string[] Names()
        {
            string[] names = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            string temp = "";
            for (int i = 0; i < names.Length; i++)
            {
                int newIndex = rand.Next(i, names.Length);
                temp = names[i];
                names[i] = names[newIndex];
                names[newIndex] = temp;
            }
            foreach (var item in names)
            {
                Console.WriteLine(item.ToString());
            }
            List<string> longNames = new List<string>();
            for (int j = 0; j < names.Length; j++)
            {
                if (names[j].Length > 4)
                {
                    longNames.Add(names[j]);
                }
            }
            return longNames.ToArray();
        }

        static void Main(string[] args)
        {
            // RandomArray();
            // CoinToss();
            Names();
        }
    }
}
