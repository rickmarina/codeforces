using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Board Moves
public class Problem1353C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            long factor = 8;
            long ans = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                ans += factor * i;
                factor += 8;
            }

            System.Console.WriteLine(ans);
        }
    }
}


