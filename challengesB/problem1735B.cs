using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Tea with Tangerines
public class Problem1735B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int x = 2 * v[0] - 1;

            var r = v.Select(e => e / x).Sum() - v.Count(e => e % x == 0);

            System.Console.WriteLine(r);
        }
    }
}


