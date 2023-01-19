using System.Linq;
using System;

namespace codeforces.challengesB;

//1475/B. New Year's Number
public class problem1475B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            int ops = n / 2020;

            int diff = n - (2020 * ops);
            if (diff <= ops)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}

