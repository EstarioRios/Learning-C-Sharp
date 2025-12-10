using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Hello");


        void CountCalculator(int goalCount, List<int> numbers)
        {
            if (goalCount > numbers.Count)
            {
                Console.WriteLine($"your entered number is bigger than {numbers.Count}");
            }
            else
            {
                var countedTime = 0;
                foreach (var item in numbers)
                {
                    if (countedTime != goalCount)
                    {
                        Console.WriteLine(item);
                        countedTime++;
                    }

                }
                if (countedTime == numbers.Count)
                {
                    Console.WriteLine("Finished");
                }
                else if (countedTime < numbers.Count)
                {
                    Console.WriteLine("Procces Finished");
                }
            }
        }
        ;

        while (true)
        {
            Console.WriteLine($"Please Enter a number betwin {numbers[0]} and {numbers.Count}");
            var input = Console.ReadLine();
            var goalCount = Convert.ToInt16(input);
            CountCalculator(goalCount, numbers);
        }
    }
}
