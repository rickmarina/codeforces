using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1478/A. Nezzar and Colorful Balls
    public class problem1478A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var balls = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                var groups = balls.GroupBy(x => x).Select(a => new { k = a.Key, v = a.Count() });

                int total = groups.MaxBy(x => x.v).v;

                Console.WriteLine(total);

            }

        }

    }

}