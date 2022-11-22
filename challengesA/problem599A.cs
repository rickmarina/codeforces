using System.Linq;
using System;

namespace codeforces.challengesA
{

    //599/A. Patrick and Shopping
    public class problem599A
    {

        public static void solution()
        {
            var d = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int res = 0;
            if (d[0] > d[1] + d[2])
            {
                res = d[1] * 2 + d[2] * 2;
            }
            else if (d[1] > d[0] + d[2])
            {
                res = d[0] * 2 + d[2] * 2;
            }
            else
            {
                int s1 = d[0] + d[2] + d[1];
                int s2 = (d[0] * 2) + (d[1] * 2);
                res = Math.Min(s1, s2);
            }
            Console.WriteLine(res);

        }

    }

}