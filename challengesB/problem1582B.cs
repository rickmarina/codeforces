using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Luntik and Subsequences
public class Problem1582B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var v = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long total1 = v.Count(x => x == 1);
            long total0 = v.Count(x => x == 0);

            // Ones * 2^zeros = ans

            long ans = total1 * (long)Math.Pow(2, total0);

            Console.WriteLine(ans);
        }
    }
}


