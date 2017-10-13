using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 0; i < elements.Count-1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    start = elements[i];
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    length = 1;
                }
            }
            if (bestLength == 1)
            {
                bestStart = elements[0];
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
