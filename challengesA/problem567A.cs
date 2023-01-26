using System.Linq;
using System;

namespace codeforces.challengesA;

//567/A. Lineland Mail
public class problem567A
{
    public static void solution()
    {
        int cities = int.Parse(Console.ReadLine());

        var x = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int max = x.Max();
        int min = x.Min();

        for (int i = 0; i < cities; i++)
        {
            int maxI = Math.Max(Math.Abs(x[i] - max), Math.Abs(x[i] - min));
            int minI = maxI;

            if (i == 0)
                minI = x[i + 1] - x[i];
            else if (i == cities - 1)
                minI = x[i] - x[i - 1];
            else
                minI = Math.Min(Math.Abs(x[i] - x[i - 1]), Math.Abs(x[i + 1] - x[i]));

            Console.WriteLine($"{minI} {maxI}");
        }
    }
}

