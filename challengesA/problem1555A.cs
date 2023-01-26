using System.Linq;
using System;

namespace codeforces.challengesA;

//1555/A. PizzaForces
public class problem1555A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            long s = n / 6;
            long r = n % 6;
            long t = 0;
            if (n <= 6)
                t = 15;
            else if (r == 0)
                t = s * 15;
            else if (r != 0 && r <= 2)
                t = s * 15 + 5;
            else if (r != 0 && r <= 4)
                t = s * 15 + 10;
            else
                t = (s + 1) * 15;

            Console.WriteLine($"{t}");
        }
    }
}

