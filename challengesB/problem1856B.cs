using System.Linq;
using System;

namespace codeforces.challengesB;

//1856/B. Good Arrays
public class problem1856B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {

            long n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            var total = a.Where(x => x > 1).Count();
            var sum = a.Where(x => x > 1).Sum();
            var sum1 = n - total;

            if (n > 1 && ((sum - total) >= sum1))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}


