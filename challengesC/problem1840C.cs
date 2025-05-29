using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Ski Resort
public class Problem1840C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {

            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            (long n, long k, long q) = (input[0], input[1], input[2]);

            // n # vacation days
            // k # days al least 
            // q # degrees 

            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long good = 0;
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] <= q)
                {
                    good++;
                }

                if (a[i] > q || i == n - 1)
                {
                    ans += Utils.CalcularCombinaciones(good, k);
                    good = 0;
                }
            }

            System.Console.WriteLine(ans);
        }
    }
}


