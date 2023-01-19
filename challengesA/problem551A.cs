using System.Linq;
using System;

namespace codeforces.challengesA;

//451/A. Game With Sticks
public class problem551A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = input[0], m = input[1];

        int min = Math.Min(n, m);
        if ((min & 1) == 1)
            Console.WriteLine("Akshat");
        else
            Console.WriteLine("Malvika");
    }
}

