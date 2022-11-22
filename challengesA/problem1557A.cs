using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1557/A. Ezzat and Two Subsequences
    public class problem1557A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

                double max = nums.Max();

                double res = max + (nums.Sum() - max) / (n - 1);

                Console.WriteLine(res);

            }

        }

    }

}