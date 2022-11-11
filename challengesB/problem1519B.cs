using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1519/B. The Cake Is a Lie
    public class problem1519B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int moves1 = (input[0] - 1);
                int moves2 = input[0] * (input[1] - 1);

                int moves = moves1 + moves2;
                if (moves == input[2])
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }

    }

}