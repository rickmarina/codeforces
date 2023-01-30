using System.Linq;
using System;

namespace codeforces.challengesA;

//709/A. Juicer
public class problem709A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = input[0], b = input[1], d = input[2];

        var oranges = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
        long juicer = 0;
        long times = 0;
        for (int i = 0; i < n; i++)
        {
            if (oranges[i] <= b)
            {
                juicer += oranges[i];

                if (juicer > d)
                {
                    juicer = 0;
                    times++;
                }
            }
        }

        Console.WriteLine(times);
    }
}

