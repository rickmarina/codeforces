using System.Linq;
using System;

namespace codeforces.challengesB;

//1326/B. Maximums
public class problem1326B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        var b = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

        double max = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(max + b[i] + " ");
            max = Math.Max(b[i] + max, max);
        }

        Console.WriteLine("");
    }
}

