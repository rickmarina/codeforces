using System;
using System.Linq;

namespace codeforces;

//A. Mainak and Array
class Program
{
    static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                ans = Math.Max(ans, v[i] - v[i + 1]);
            }
            ans = Math.Max(ans, v[n - 1] - v[0]);
            ans = Math.Max(ans, v[n - 1] - v.Min());
            ans = Math.Max(ans, v.Max() - v[0]);

            System.Console.WriteLine(ans);
        }
    }
}
