using System.Linq;
using System;

namespace codeforces.challengesB;

//1374/B. Multiply by 2, divide by 6
public class problem1374B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long bak = n;
            int total = 0;
            while (n > 1 || n > bak)
            {

                if (n % 6 == 0)
                    n = n / 6;
                else
                    n *= 2;

                total++;
            }
            Console.WriteLine(n == 1 ? total : -1);
        }
    }
}

