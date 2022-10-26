using System.Linq;
using System;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem1660A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var ab = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (ab[0] == 0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine(ab[1] * 2 + ab[0] + 1);

            }

        }

    }

}