using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1562/A. The Miracle and the Sleeper
    public class problem1562A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int l = nums[0], r = nums[1];

                if (l == r)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    int mid = (r / 2) + 1;
                    if (mid >= l)
                    {
                        Console.WriteLine(nums[1] % mid);
                    }
                    else
                    {
                        Console.WriteLine(nums[1] % nums[0]);
                    }
                }
            }

        }

    }

}