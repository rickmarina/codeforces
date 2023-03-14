using System.Linq;
using System;

namespace codeforces.challengesA;

//598/A. Tricky Sum
public class problem598A
{

    public static void solution()
    {
        // sum of all integers from 1 to n, but you should take all powers of two with minus in the sum.

        // sum of all negatives from 1 to n : 2^n-1
        // we have to find out the maximun number possible for 2^i <= n
        // then, sum all the arithmetic serie then substract 2*(2^n-1)

        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {

            long n = long.Parse(Console.ReadLine());

            long i = 0;
            while (Math.Pow(2, i) <= n)
            {
                i++;
            }

            long sumSerie = n * (n + 1) / 2;
            long sumNegative = (long)Math.Pow(2, i) - 1;

            //Console.WriteLine($"{sumSerie} {sumNegative}");

            long result = sumSerie - (sumNegative * 2);

            Console.WriteLine($"{result}");

        }
    }
}

