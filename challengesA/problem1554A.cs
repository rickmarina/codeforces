using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1554/A. Cherry
    public class problem1554A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                long prev = 0;
                long res = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    long mult = nums[i] * prev;
                    if (mult > res)
                        res = mult;
                    prev = nums[i];
                }

                Console.WriteLine(res);

            }

        }

    }

}