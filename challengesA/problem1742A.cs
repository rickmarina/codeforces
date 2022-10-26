using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1742/A. Sum
    public class problem1742A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int c = Math.Abs(nums[0] - nums[1]) - nums[2];
                int d = Math.Abs(nums[0] + nums[1]) - nums[2];

                if (c == 0 || d == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");


            }

        }

    }

}