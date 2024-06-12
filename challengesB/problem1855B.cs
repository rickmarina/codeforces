using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Longest Divisors Interval
public class Problem1855B
{

    public static void solution()
    {
        //Can get longest divisors interval, starting dividing num from 1 to num and counting while 
        //division rest is not zero. 

        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long num = long.Parse(Console.ReadLine());
            long i = 1;
            while (num % i == 0) i++;

            Console.WriteLine(i - 1);
        }
    }
}


