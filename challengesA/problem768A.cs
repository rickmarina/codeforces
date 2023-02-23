using System.Linq;
using System;

namespace codeforces.challengesA;

//768/A. Oath of the Night's Watch
public class problem768A
{

    public static void solution()
    {
        int stewards = int.Parse(Console.ReadLine());

        var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

        long min = a.Min(), max = a.Max();

        var ans = a.Count(x => x > min && x < max);

        Console.WriteLine(ans);
    }
}

