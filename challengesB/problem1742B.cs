using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1742/B. Increasing
    public class ClaseBase
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var res = Console.ReadLine().Split(" ").Select(int.Parse).GroupBy(g => g).Select(s => new { k = s.Key, v = s.Count() }).Any(a => a.v > 1);
                Console.WriteLine(res ? "NO" : "YES");

            }


        }

    }

}