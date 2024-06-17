using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Mainak and Array
public class Problem1726A
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ans = 0;
            for (int i = 0; i + 1 < n; i++)
            {
                ans = Math.Max(ans, v[i] - v[i + 1]);
            }
            ans = Math.Max(ans, v[n - 1] - v[0]);

            int mini = v.Min();
            ans = Math.Max(ans, v[n - 1] - mini);

            int maxo = v.Max();
            ans = Math.Max(ans, maxo - v[0]);

            System.Console.WriteLine(ans);
        }
    }
}


