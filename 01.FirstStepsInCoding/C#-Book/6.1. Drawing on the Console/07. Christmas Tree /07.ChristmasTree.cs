07. Christmas Tree using System;

namespace _07.ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                string stars = new string('*', i);
                string spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(new string(' ', n - n));
                Console.Write(stars);
                Console.WriteLine();
            }
        }
    }
}
