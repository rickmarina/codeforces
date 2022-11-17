using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1691/A. Beat The Odds
    public class problem1691A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int totalEven = nums.Count(x => (x & 1) == 0);
                int totalOdd = nums.Count(x => (x & 1) == 1);

                Console.WriteLine($"{Math.Min(totalEven, totalOdd)}");
            }

        }

    }

}