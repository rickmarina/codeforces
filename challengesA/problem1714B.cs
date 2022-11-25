using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1714/B. Remove Prefix
    public class problem1714B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                HashSet<int> set = new();

                int res = 0;
                for (int i = n - 1; i >= 0; i--)
                {
                    if (set.Contains(nums[i]))
                    {
                        res = i + 1;
                        break;
                    }

                    set.Add(nums[i]);
                }

                Console.WriteLine(res);
            }

        }

    }

}