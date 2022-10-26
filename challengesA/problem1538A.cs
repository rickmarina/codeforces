using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1538/A. Stone Game
    public class problem1538A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var powers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                int pG = powers.IndexOf(powers.Max());
                int pL = powers.IndexOf(powers.Min());

                int minG = Math.Min(n - pG, pG + 1);
                int minL = Math.Min(n - pL, pL + 1);

                int total = 0;
                if (minG <= minL)
                {
                    if (pL < pG)
                    {
                        total += minG + Math.Min(n - pL - minG, pL + 1);
                    }
                    else
                    {
                        total += minG + Math.Min(n - pL, pL + 1 - minG);
                    }
                }
                else
                {
                    if (pL > pG)
                    {
                        total += minL + Math.Min(n - pG - minL, pG + 1);
                    }
                    else
                    {
                        total += minL + Math.Min(n - pG, pG + 1 - minL);
                    }
                }
                Console.WriteLine($"{total}");
                //Console.WriteLine($"pG: {pG} minG:{minG} pL:{pL} minL:{minL} total:{total}");
            }


        }

    }

}