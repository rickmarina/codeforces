using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Wet Shark and Odd and Even
public class Problem621A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var v = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long totalEven = v.Sum(x => (x & 1) == 0 ? x : 0);
        var vOdd = v.Where(x => (x & 1) == 1).OrderByDescending(x => x).ToArray();

        long totalOdd = 0;
        if ((vOdd.Length % 2) != 0)
            totalOdd = vOdd[..^1].Sum();
        else totalOdd = vOdd.Sum();

        // System.Console.WriteLine($"total even: {totalEven} totalOdd : {totalOdd}");
        System.Console.WriteLine($"{totalEven + totalOdd}");
    }
}


