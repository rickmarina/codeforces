using System.Linq;
using System;

namespace codeforces.challengesB;

//1617/B. GCD Problem
public class problem1617B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            long a = 0, b = 0, c = 1;
            if (n % 2 == 0)
            {
                b = 2;
                a = n - 3;
            }
            else
            {
                n = (n - 1) / 2;
                if (n % 2 == 0)
                {
                    b = n - 1;
                    a = n + 1;
                }
                else
                {
                    b = n - 2;
                    a = n + 2;
                }

            }

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}



