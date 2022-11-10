using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1551/B1. Wonderful Coloring - 1
    public class problem1551B1
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var word = Console.ReadLine();
                var groups = word.GroupBy(x => x).Select(g => new { k = g.Key, v = g.Count() });
                int total = groups.Where(x => x.v > 1).Count() + (groups.Where(x => x.v == 1).Count() / 2);

                Console.WriteLine(total);
            }

        }

    }

}