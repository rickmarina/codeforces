using System.Linq;
using System;

namespace codeforces.challengesA;

//1350/A. Orac and Factors
public class problem1350A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0], k = input[1];

            int f = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    f = i;
                    break;
                }
            }

            k--;
            n += f + (2 * k);
            Console.WriteLine(n);
        }
    }
}

