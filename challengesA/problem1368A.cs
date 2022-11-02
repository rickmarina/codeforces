using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1368/A. C+=
    public class problem1368A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var abn = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int total = 1;
                while (abn[0] + abn[1] <= abn[2])
                {
                    if (abn[0] > abn[1])
                        abn[1] += abn[0];
                    else
                        abn[0] += abn[1];

                    total++;
                }

                Console.WriteLine(total);

            }

        }

    }

}