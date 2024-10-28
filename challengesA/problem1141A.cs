using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Game 23
public class Problem1141A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        (long n, long m) = (input[0], input[1]);

        int total = 0;

        while (n < m)
        {
            if ((m / n) % 3 == 0)
                n *= 3;
            else if ((m / n) % 2 == 0)
                n *= 2;
            else
            {
                total = -1;
                break;
            }
            total++;
        }

        System.Console.WriteLine(total);
    }
}


