using System.Linq;
using System;

namespace codeforces.challengesB;

//1697/B. Promo
public class ClaseBase
{

    public static void solution()
    {
        var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = dat[0], q = dat[1];

        var a = Console.ReadLine().Split(" ").Select(long.Parse).OrderByDescending(x => x).ToArray();

        long[] b = new long[n];
        b[0] = a[0];
        for (int i = 1; i < n; i++)
        {
            b[i] = b[i - 1] + a[i];
        }
        while (q-- > 0)
        {
            var query = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x = query[0], y = query[1];

            long ans = b[x - 1] - b[x - y] + a[x - y];
            Console.WriteLine(ans);
        }
    }
}

