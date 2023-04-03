using System.Linq;
using System;

namespace codeforces.challengesB;

//1095/B. Array Stabilization
public class problem1095B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        var dat = Console.ReadLine().Split(" ").Select(int.Parse).OrderBy(x => x).ToArray();

        var ans = Math.Min(dat[n - 2] - dat[0], dat[n - 1] - dat[1]);
        Console.WriteLine(ans);
    }

    static long Inestability(long max, long min) => max - min;
}




