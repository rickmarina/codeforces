using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Equalize Prices
public class Problem1183B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int n, int k) = (input[0], input[1]);

            var v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = v.Max();
            int min = v.Min();

            double B = min + k;

            if (Math.Abs(max - B) <= k)
            {
                System.Console.WriteLine(B);
            }
            else
            {
                System.Console.WriteLine("-1");
            }

        }

    }
}


