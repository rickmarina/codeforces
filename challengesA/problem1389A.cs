using System.Linq;
using System;

namespace codeforces.challengesA
{
    //1389/A. LCM Problem
    public class problem1389A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var lr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int x = lr[0], y = x + 1;

                if (lr[1] % lr[0] == 0)
                {
                    x = lr[0];
                    y = lr[1];
                }
                else
                {
                    y = x * 2;
                }

                if (x < lr[1] && y <= lr[1] && LCM(x, y) <= lr[1])
                    Console.WriteLine($"{x} {y}");
                else
                    Console.WriteLine("-1 -1");
            }

        }
        public static int gcf(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Least Common Multiple (smallest multiple have in common)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int LCM(int a, int b)
        {
            return (a / gcf(a, b)) * b;
        }
    }

}