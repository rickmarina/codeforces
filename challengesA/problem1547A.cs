using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1547/A. Shortest Path with Obstacle
    public class problem1547A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            Console.ReadLine();
            while (t-- > 0)
            {
                var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var f = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                Console.ReadLine();
                int moves = 0;
                int extra = 0;
                //same vertical or horizontal 
                if (a[0] == b[0] && f[0] == a[0] && f[1] > Math.Min(a[1], b[1]) && f[1] < Math.Max(a[1], b[1]))
                {
                    extra += 2;
                }
                else if (a[1] == b[1] && f[1] == a[1] && f[0] > Math.Min(a[0], b[0]) && f[0] < Math.Max(a[0], b[0]))
                {
                    extra += 2;
                }

                moves = Math.Abs(a[0] - b[0]) + Math.Abs(a[1] - b[1]) + extra;


                Console.WriteLine(moves);

            }

        }

    }

}