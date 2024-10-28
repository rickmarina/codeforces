using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Good Prefixes
public class Problem1985C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = int.Parse(Console.ReadLine());

            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long sum = 0;
            long prefixes = 0;
            long max = 0;
            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, nums[i]);
                if (sum - max + nums[i] == max)
                {
                    prefixes++;
                    //System.Console.WriteLine($"{string.Join(" ",nums.Take(i+1))}");
                }

                sum += nums[i];
            }

            System.Console.WriteLine($"{prefixes}");
        }

    }
}


