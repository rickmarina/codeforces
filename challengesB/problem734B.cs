using System.Linq;
using System;

namespace codeforces.challengesA
{

    //734/B. Anton and Digits
    public class problem734B
    {

        public static void solution()
        {
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int k2 = nums[0], k3 = nums[1], k5 = nums[2], k6 = nums[3];

            int x = Math.Min(k2, Math.Min(k5, k6));
            int y = Math.Min(k3, k2 - x);

            Console.WriteLine((x * 256) + (y * 32));

        }

    }

}