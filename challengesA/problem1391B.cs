using System.Linq;
using System;

namespace codeforces.challengesB;

//1391/B. Fix You
public class problem1391B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = nm[0], m = nm[1];

            int total = 0;
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                if (line.Last() == 'R')
                    total++;
                if (i == n - 1)
                    total += line.Count(x => x == 'D');
            }

            Console.WriteLine(total);


        }
    }
}

