using System.Linq;
using System;

namespace codeforces.challengesA;

//160/A. Twins
public class problem160A
{

    public static void solution()
    {
        var coins = Console.ReadLine();
        var values = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(x => x).ToArray();

        int sum = values.Sum();
        int taken = 0;
        int rest = sum - taken;
        int i = 0;
        while (rest >= taken)
        {
            taken += values[i];
            rest -= values[i];
            i++;
        }

        Console.WriteLine(i);
    }
}

