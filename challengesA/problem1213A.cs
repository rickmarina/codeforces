using System.Linq;
using System;

namespace codeforces.challengesA;

//1213/A. Chips Moving
public class problem1213A
{

    public static void solution()
    {
        int chips = int.Parse(Console.ReadLine());

        var x = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

        long odds = x.Count(x => (x & 1) == 1);

        Console.WriteLine(Math.Min(odds, chips - odds));
    }
}

