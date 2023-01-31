using System.Linq;
using System;

namespace codeforces.challengesA;

//275/A. Lights Out
public class problem275A
{

    public static void solution()
    {
        var map = Enumerable.Range(0, 3).Select(x => Console.ReadLine().Split(" ").Select(int.Parse).ToArray()).ToArray();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int times = map[i][j];
                if (i > 0)
                    times += map[i - 1][j];
                if (i < 2)
                    times += map[i + 1][j];
                if (j < 2)
                    times += map[i][j + 1];
                if (j > 0)
                    times += map[i][j - 1];

                if (times % 2 == 0)
                    Console.Write("1");
                else
                    Console.Write("0");
            }
            Console.WriteLine();

        }
    }
}

