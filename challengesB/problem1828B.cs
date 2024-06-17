using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Permutation Swap
public class Problem1828B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                res = Utils.GCD(res, Math.Abs(s[i - 1] - i));
            }

            System.Console.WriteLine(res);
        }
    }

    
}


