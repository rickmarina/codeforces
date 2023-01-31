using System.Linq;
using System;

namespace codeforces.challengesA;

//276/A. Lunch Rush
public class problem276A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = input[0], k = input[1];

        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            var res = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (res[1] > k)
                max = Math.Max(max, res[0] - (res[1] - k));
            else
                max = Math.Max(max, res[0]);
        }

        Console.WriteLine(max);
    }
}

