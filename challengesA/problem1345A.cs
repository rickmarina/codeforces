using System.Linq;
using System;

namespace codeforces.challengesA;

//1345/A. Puzzle Pieces
public class problem1345A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = nums[0], m = nums[1];

            if (n == 1 || m == 1)
            {
                Console.WriteLine("YES");
            }
            else if (n == 2 && m == 2)
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

