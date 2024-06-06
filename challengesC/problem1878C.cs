using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Vasilije in Cacak
public class Problem1878C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long[] nums = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            long n = nums[0]; //between 1 to n 
            long k = nums[1]; //k distinct nums 
            long x = nums[2]; //equal to x

            long min = (long)((k / 2.0) * (1 + k)); //sum from 1 to k
            long max = (long)((k / 2.0) * (n - k + 1 + n)); //sum from n to n-k

            // Console.WriteLine($"min: {min} max: {max} target: {x}");
            if (min > x || max < x)
                System.Console.WriteLine($"NO");
            else
                System.Console.WriteLine($"YES");

        }
    }
}


