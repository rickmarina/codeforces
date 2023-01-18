using System.Linq;
using System;

namespace codeforces.challengesA;

//337/A. Puzzles
public class problem337A
{

    public static void solution()
    {
        var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = nums[0], m = nums[1];
        var pieces = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        var r = pieces.OrderBy(x => x).ToArray();

        int diff = r[n - 1] - r[0];

        for (int i = 1; i <= m - n; ++i)
        {
            if (r[i + n - 1] - r[i] < diff)
                diff = r[i + n - 1] - r[i];
        }

        Console.WriteLine(diff);
    }
}

