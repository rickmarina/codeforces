using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1382/A. Common Subsequence
    public class problem1382A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int res = a.Where(x => b.Any(y => y == x)).FirstOrDefault();

                if (res > 0)
                {
                    Console.WriteLine($"YES");
                    Console.WriteLine($"1 {res}");
                }
                else
                {
                    Console.WriteLine($"NO");
                }

            }


        }

    }

}