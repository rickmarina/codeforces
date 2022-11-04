using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1618/A. Polycarp and Sums of Subsequences
    public class problem1618A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (b[0] + b[1] + b[2] == b[6])
                {
                    Console.WriteLine($"{b[0]} {b[1]} {b[2]}");
                }
                else
                {
                    Console.WriteLine($"{b[0]} {b[1]} {b[3]}");
                }
            }

        }

    }

}