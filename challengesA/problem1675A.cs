using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1675/A. Food for Animals
    public class problem1675A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int a = input[0], b = input[1], c = input[2], x = input[3], y = input[4];
                int rd = Math.Max(x - a, 0);
                int rc = Math.Max(y - b, 0);

                if (rd + rc > c)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");


            }

        }

    }

}