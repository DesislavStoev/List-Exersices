using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SumReversedNumbers
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string num = "";
            int reverse = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                num = numbers[i].ToString();
                num = Reverse(num);
                reverse =int.Parse(num);
                sum += reverse;
            }
            Console.WriteLine(sum);
        }
    }
}
