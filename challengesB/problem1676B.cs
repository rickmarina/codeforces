using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1676/B. Equal Candies
    public class problem1676B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int boxes = int.Parse(Console.ReadLine());
                var candies = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                int min = candies.Min();

                int total = candies.Select(x => x - min).Sum();

                Console.WriteLine(total);

            }

        }

    }

}