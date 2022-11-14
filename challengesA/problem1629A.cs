using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1629/A. Download More RAM
    public class problem1629A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int n = input[0];
                int k = input[1];

                var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                var serie = a.Select((x, i) => new { a = x, b = b[i] }).ToArray();

                var ordered = serie.OrderBy(x => x.a).ToArray();

                for (int i = 0; i < n; i++)
                {
                    if (ordered[i].a <= k)
                        k += ordered[i].b;
                }

                Console.WriteLine(k);

            }

        }

    }

}