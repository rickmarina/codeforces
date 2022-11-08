using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1433/B. Yet Another Bookshelf
    public class problem1433B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());
                var cad = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                var r = cad.Select((x, i) => x == 1 ? i : -1).Where(x => x != -1).ToArray();
                int total = 0;
                if (r.Count() > 1)
                {
                    for (int i = 0; i < r.Count() - 1; i++)
                    {
                        total += Math.Abs(r[i] - r[i + 1]) - 1;
                    }
                }

                Console.WriteLine(total);

            }

        }

    }

}