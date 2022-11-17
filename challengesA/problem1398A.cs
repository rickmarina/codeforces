using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1398/A. Bad Triangle
    public class problem1398A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                //as is sorted in non-decreasing order , first two values al minimum
                int a = 0, b = 1, c = 0;

                for (int i = 2; i < n; i++)
                {
                    //one side cannot be greater than other two
                    if (nums[i] >= nums[a] + nums[b])
                    {
                        c = i;
                        break;
                    }
                }

                if (c != 0)
                {
                    Console.WriteLine($"{a + 1} {b + 1} {c + 1}");
                }
                else
                {
                    Console.WriteLine($"-1");
                }

            }

        }

    }

}