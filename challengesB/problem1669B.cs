using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1669/B. Triple
    public class problem1669B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                _ = int.Parse(Console.ReadLine());

                var s = Console.ReadLine().Split(" ").Select(int.Parse);
                var g = s.GroupBy(x => x).Select(g => new { k = g.Key, c = g.Count() }).Where(w => w.c >= 3).Select(s => s.k).Take(1).ToList();

                if (g.Count() > 0)
                    Console.WriteLine(g[0]);
                else
                    Console.WriteLine("-1");
            }

        }

    }

}