using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1296/A. Array with Odd Sum
    public class problem1296A
    {

        public static void solution()
        {
            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var seq = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                var sum = seq.Sum();
                if ((sum & 1) == 1)
                    Console.WriteLine("YES");
                else
                {
                    var totalEven = seq.Count(x => ((x & 1) == 0));
                    var totalOdd = seq.Count(x => ((x & 1) == 1));
                    if (totalEven > 0 && totalOdd > 0)
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

    }

}