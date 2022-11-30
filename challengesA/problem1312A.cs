using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1312/A. Two Regular Polygons
    public class problem1312A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int n = dat[0], m = dat[1];

                if (n % m == 0)
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