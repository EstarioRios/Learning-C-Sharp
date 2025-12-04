using System;
using System.Threading.Tasks.Sources;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,
        };

        while (true)
        {
            Console.WriteLine($"Wrtie a number from 1 to {numbers.Count}");
            var goalCount = Console.ReadLine();
            Console.WriteLine("===============================");

            if (Convert.ToInt32(goalCount) <= numbers.Count)
            {
                var console_time = 0;
                foreach (var number in numbers)
                {


                    if (console_time < Convert.ToInt32(goalCount))
                    {
                        Console.WriteLine(number);
                        console_time++;
                        continue;
                    }
                    else
                    {

                        break;
                    }
                }
                Console.WriteLine("Finished");

            }
            else if (Convert.ToInt32(goalCount) > numbers.Count)
            {
                Console.WriteLine($"your target goal is hight, max is {numbers.Count}");
                Console.WriteLine("try one more time");
                continue;

            }
        }
    }
}
