using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Three Threadlets
public class Problem1881B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            (long a, long b, long c) = (input[0], input[1], input[2]);

            (long len1, long cuts1) = MinCut(a, b);
            (long len2, long cuts2) = MinCut(len1, c);

            long minLen = Math.Min(len1, len2);
            // System.Console.WriteLine($"minCut: {minLen}");

            (_, long totalA) = MinCut(minLen, a);
            (_, long totalB) = MinCut(minLen, b);
            (_, long totalC) = MinCut(minLen, c);

            // System.Console.WriteLine($"totalCuts: {totalA+totalB+totalC}");

            if (totalA + totalB + totalC > 3)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
    static (long, long) MinCut(long a, long b)
    {
        long max = Math.Max(a, b);
        long min = Math.Min(a, b);

        long r = max % min;

        if (r == 0)
            return (min, (max / min) - 1);
        else
            return (r, (max / r) - 1);
    }
}


