using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
            21,22,23,24,25,26,27,28,29,30,31
        };

        void CountCalculator(int goalCount, List<int> numbers)
        {
            if (goalCount <= numbers.Count)
            {
                int console_time = 0;
                foreach (var number in numbers)
                {
                    if (console_time < goalCount)
                    {
                        Console.WriteLine(number);
                        console_time++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (console_time == numbers.Count)
                    Console.WriteLine("Finished");
                else
                    Console.WriteLine("your Process Finished");
            }
            else
            {
                Console.WriteLine($"Your target goal is high, max is {numbers.Count}");
                Console.WriteLine("Try one more time");
            }
        }

        while (true)
        {
            Console.WriteLine($"Write a number from 1 to {numbers.Count}");
            var input = Console.ReadLine();
            Console.WriteLine("===============================");

            if (!int.TryParse(input, out int goalCount))
            {
                Console.WriteLine("Not a valid number. Try again.");
                continue;
            }

            CountCalculator(goalCount, numbers);
        }
    }
}
