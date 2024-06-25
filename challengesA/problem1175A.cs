using System.Linq;
using System;

namespace codeforces.challengesA;

//A. From Hero to Zero
public class Problem1175A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            (long n, long k) = (input[0], input[1]);

            long steps = 0;

            while (n > 0)
            {
                // System.Console.WriteLine($"n: {n} steps: {steps}");
                if (k > n)
                {
                    steps += n;
                    break;
                }

                if (n % k == 0)
                {
                    n = n / k;
                    steps++;
                }
                else
                {
                    long over = (n % k);
                    n -= over;
                    steps += over;
                }
            }

            System.Console.WriteLine(steps);
        }
    }
}


