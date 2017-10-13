using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.ArrayManipulator
{
    class Program
    {

        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToList();
            List<int> sum = new List<int> { };
            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command
                    .Split(' ')
                    .ToList();
                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandArgs[1]),
                        commandArgs.Skip(2).Select(int.Parse).ToList());
                }
                else if (commandArgs[0] == "contains")
                {
                    int number = int.Parse(commandArgs[1]);
                    Console.WriteLine(numbers.IndexOf(number));
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    int number = int.Parse(commandArgs[1]);
                    number = number % numbers.Count;
                    var shift = numbers.Take(number).ToArray();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(shift);
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    if (numbers.Count % 2 == 0)
                    {
                        for (int i = 0; i < numbers.Count; i += 2)
                        {
                            sum.Add(numbers[i] + numbers[i + 1]);
                        }
                        numbers = new List<int>(sum);
                        sum.Clear();
                    }
                    else if (numbers.Count % 2 != 0 && numbers.Count > 1)
                    {
                        for (int i = 0; i < numbers.Count -1; i += 2)
                        {
                            sum.Add(numbers[i] + numbers[i + 1]);
                        }
                        sum.Add(numbers[numbers.Count - 1]);
                        numbers = new List<int>(sum);
                        sum.Clear();
                    }
                    else if (numbers.Count == 1)
                    {
                        sum.Add(numbers[0]);
                        numbers = new List<int>(sum);
                        sum.Clear();
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
