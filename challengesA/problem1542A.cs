using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1542/A. Odd Set
    public class problem1542A
    {

        public static void solution()
        {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {

                var n = Console.ReadLine();
                var num = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                var totalEven = num.Count(x => (x & 1) == 0);
                var totalOdd = num.Count(x => (x & 1) == 1);

                Console.WriteLine(totalEven == totalOdd ? "YES" : "NO");
            }

        }

    }

}