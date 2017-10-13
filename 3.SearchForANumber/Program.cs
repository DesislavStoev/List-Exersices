using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> elementsTake = elements.Take(number[0]).ToList();
            elementsTake.RemoveRange(0,number[1]);
            if (elementsTake.Contains(number[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
