using System.Linq;
using System;

namespace codeforces.challengesA;

//318/A. Even Odds
public class problem318A
{

    public static void solution()
    {
        var nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
        double n = nums[0], k = nums[1];

        double end = Math.Ceiling(n / 2.0);
        int a1 = 1;
        if (k > end)
        {
            a1 = 2;
            k -= end;
        }
        double an = a1 + (k - 1) * 2;

        Console.WriteLine(an);
    }
}

