using System.Linq;
using System;

namespace codeforces.challengesB;

//1607/B. Odd Grasshopper
public class problem1607B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            long x0 = dat[0], n = dat[1];

            if (x0 % 2 != 0)
            {
                long s = n % 4;
                if (s == 1) x0 += n;
                if (s == 2) x0--;
                if (s == 3) x0 = x0 - n - 1;
            }
            else
            {
                long s = n % 4;
                if (s == 1) x0 -= n;
                if (s == 2) x0++;
                if (s == 3) x0 = x0 + n + 1;
            }

            Console.WriteLine(x0);
        }

    }
}

