using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "Odd" && command[0] != "Even" )
            {
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == int.Parse(command[1]))
                        {
                            nums.Remove(int.Parse(command[1]));
                            i--;
                        }
                        
                    }
                }
                else if (command[0] == "Insert")
                {       
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(' ');
            }
            if (command[0] == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        Console.Write(nums[i] + " ");
                    }

                }
                Console.WriteLine();
            }
            else if (command[0] == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        Console.Write(nums[i] + " ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
