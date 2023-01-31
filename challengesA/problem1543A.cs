using System.Linq;
using System;

namespace codeforces.challengesA;

//1543/A. Exciting Bets
public class problem1543A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            long a = input[0], b = input[1];

            long max = Math.Abs(a - b);
            long moves = 0;

            if (max > 0)
                moves = Math.Min(max - Math.Min(a, b) % max, Math.Min(a, b) % max);


            Console.WriteLine($"{max} {moves}");
        }
    }
}

