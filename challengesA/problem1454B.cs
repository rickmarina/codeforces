using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1454/B. Unique Bid Auction
    public class problem1454B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());
                var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                var groups = nums.GroupBy(x => x).Select(s => new { k = s.Key, v = s.Count() });

                int min = 0;
                int index = -1;
                if (groups.Any(x => x.v == 1))
                {
                    min = groups.Where(x => x.v == 1).Select(x => x.k).Min();
                    index = nums.FindIndex(x => x == min);
                    Console.WriteLine(index + 1);
                }
                else
                {
                    Console.WriteLine(index);
                }


            }

        }

    }

}