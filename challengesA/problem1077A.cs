using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1077/A. Frog Jumping
    public class problem1077A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var jumps = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                long total = 0, j = jumps[2], a = jumps[0], b = jumps[1];

                if (j % 2 == 0)
                {
                    total = a * (j / 2) - b * (j / 2);
                }
                else
                {
                    //int tA = (int)Math.Ceiling(j/2.0);
                    //int tB = (int)Math.Ceiling(j/2.0)-1;
                    long tA = (j / 2) + 1;
                    long tB = (j / 2);
                    total = a * tA - b * tB;
                }

                Console.WriteLine(total);

            }

        }

    }

}