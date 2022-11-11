using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1692/B. All Distinct
    public class problem1692B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                var serie = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int td = serie.Distinct().Count();
                int r = n - td;
                if (r % 2 == 0)
                    Console.WriteLine(td);
                else
                    Console.WriteLine(td - 1);

            }


        }

    }

}