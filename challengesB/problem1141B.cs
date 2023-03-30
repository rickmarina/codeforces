using System.Linq;
using System;

namespace codeforces.challengesB;

//1141/B. Maximal Continuous Rest
public class problem1141B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int maxRest = 0;
        int rest = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            if (a[i % n] == 1)
            {
                rest++;
                maxRest = Math.Max(maxRest, rest);
            }
            else
            {
                rest = 0;
            }
        }

        Console.WriteLine(maxRest);
    }
}




