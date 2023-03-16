using System.Linq;
using System;

namespace codeforces.challengesB;

//1705/B. Mark the Dust Sweeper
public class problem1705B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine()); //# rooms
            var dust = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            long total = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (dust[i] == 0 && total > 0)
                    total++;
                else
                    total += dust[i];
            }

            Console.WriteLine(total);
        }
    }
}

