using System.Linq;
using System;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem686A
    {

        public static void solution()
        {
            var nx = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int dis = 0;
            long total = nx[1];
            for (int i = 0; i < nx[0]; i++)
            {
                var line = Console.ReadLine().Split(" ");
                long num = long.Parse(line[1]);

                if (line[0] == "+")
                    total += num;
                else if (num <= total)
                    total -= num;
                else
                    dis++;

            }

            Console.WriteLine($"{total} {dis}");

        }

    }

}