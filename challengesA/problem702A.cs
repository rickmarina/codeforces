using System.Linq;
using System;

namespace codeforces.challengesA
{
    //702/A. Maximum Increase
    public class problem702A
    {
        public static void solution()
        {
            int n = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int gmax = 1;
            int max = 1;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i - 1])
                    max++;
                else
                {
                    max = 1;
                }
                gmax = Math.Max(gmax, max);
            }
            Console.WriteLine(gmax);
        }
    }
}