using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1196/A. Three Piles of Candies
    public class problem1196A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var nums = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

                Console.WriteLine(nums.Sum() / 2);
            }

        }

    }

}