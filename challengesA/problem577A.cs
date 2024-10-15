using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Multiplication Table
public class Problem577A
{

    public static void solution()
    {
        var inputXY = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        (long n, long x) = (inputXY[0], inputXY[1]);

        HashSet<long> set = new();

        for (int i = 1; i <= n; i++)
        {
            if (x % i == 0 && x / i <= n)
            {
                set.Add(i);
            }
        }

        System.Console.WriteLine($"{set.Count}");

    }
}


