using System.Linq;
using System;

namespace codeforces.challengesA;

//1771/A. Hossam and Combinatorics
public class problem1771A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = int.Parse(Console.ReadLine());  //# positive integers
            var a = Console.ReadLine().Split(" ").Select(long.Parse).OrderBy(x => x).ToArray();

            long result = 0;
            if (a[0] == a[n - 1])
            {
                result = (n * n) - n; // or n* (n-1)
            }
            else
            {
                long totalMin = 1;
                long i = 1;
                while (i < n && a[i++] == a[0]) totalMin++;

                long totalMax = 1;
                long j = n - 2;
                while (j >= 0 && a[j--] == a[n - 1]) totalMax++;

                result = totalMin * totalMax * 2;
            }
            Console.WriteLine($"{result}");

        }
    }
}


