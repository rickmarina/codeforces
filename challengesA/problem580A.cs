using System.Linq;
using System;

namespace codeforces.challengesA;

//580/A. Kefa and First Steps
public class problem580A
{
    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var values = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int prev = values[0];
        int total = 1;
        int max = 1;

        for (int i = 1; i < n; i++)
        {
            if (values[i] >= prev)
            {
                total++;
                max = Math.Max(max, total);
            }
            else
            {
                total = 1;
            }
            prev = values[i];
        }

        Console.WriteLine(max);
    }
}

