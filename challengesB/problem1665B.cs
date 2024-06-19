using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Array Cloning Technique
public class Problem1665B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var groups = v.GroupBy(x => x).Select(x => new { k = x.Key, v = x.Count() }).OrderByDescending(x => x.v).ToList();


            long total = groups[0].v;
            long clones = 0;
            long swaps = 0;
            long totalSwaps = 0;
            while (total < n)
            {
                clones++; //clone
                swaps = Math.Min(total, n - total);
                totalSwaps += swaps;
                total += swaps;
                // System.Console.WriteLine($"clon#: {clones} total: {total} swaps {swaps}");
            }

            System.Console.WriteLine(clones + totalSwaps);
        }
    }
}


