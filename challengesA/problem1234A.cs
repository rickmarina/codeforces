using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1234/A. Equalize Prices Again
    public class problem1234A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var prices = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                double avg = Math.Ceiling(prices.Average());

                Console.WriteLine(avg);

                System.Console.WriteLine();

            }

        }

    }

}