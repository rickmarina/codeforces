using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1481/A. Space Navigation
    public class problem1481A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var planetforces = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var orders = Console.ReadLine();

                int hL = orders.Count(x => x == 'L');
                int hR = orders.Count(x => x == 'R');
                int hU = orders.Count(x => x == 'U');
                int hD = orders.Count(x => x == 'D');

                bool horizontal = false;
                if (planetforces[0] > 0)
                {
                    if (hR >= planetforces[0])
                        horizontal = true;
                }
                else
                {
                    if (hL >= Math.Abs(planetforces[0]))
                        horizontal = true;
                }

                bool vertical = false;
                if (planetforces[1] > 0)
                {
                    if (hU >= planetforces[1])
                        vertical = true;
                }
                else
                {
                    if (hD >= Math.Abs(planetforces[1]))
                        vertical = true;
                }

                if (horizontal && vertical)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");

                }

            }

        }

    }

}