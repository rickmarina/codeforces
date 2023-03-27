using System.Linq;
using System;

namespace codeforces.challengesA;

//1720/A. Burenka Plays with Fractions
public class problem1720A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(long.Parse).ToList();

            long a = dat[0], b = dat[1];  // a/b
            long c = dat[2], d = dat[3]; // c/d

            long num = c * b;
            long den = a * d;

            if (num == den)
                Console.WriteLine("0");
            else if (num == 0 || den == 0)
                Console.WriteLine("1");
            else if (num % den == 0 || den % num == 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("2");

        }
    }
}




