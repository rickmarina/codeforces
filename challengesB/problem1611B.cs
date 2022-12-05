using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1611/B. Team Composition: Programmers and Mathematicians
    public class problem1611B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int p = data[0], m = data[1];

                int total = 0;
                if (p == 0 || m == 0)
                {
                    total = 0;
                    Console.WriteLine(total);
                }
                else if (p == m)
                {
                    total = (p + m) / 4;
                    Console.WriteLine(total);
                }
                else if (p > m)
                {
                    int d = p - m;
                    p -= d;
                    d /= 2;
                    d = Math.Min(p, d);
                    p -= d;
                    m -= d;
                    d += (p + m) / 4;
                    Console.WriteLine(d);
                }
                else
                {
                    int d = m - p;
                    m -= d;
                    d /= 2;
                    d = Math.Min(p, d);
                    p -= d;
                    m -= d;
                    d += (p + m) / 4;
                    Console.WriteLine(d);
                }

            }

        }

    }
}