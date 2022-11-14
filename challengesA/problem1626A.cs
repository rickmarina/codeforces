using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1626/A. Equidistant Letters
    public class problem1626A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var serie = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                var group = serie.Select(x => x % 2).GroupBy(g => g).Select(s => new { k = s.Key, v = s.Count() });

                if (group.Count() == 1)
                {
                    Console.WriteLine("YES");
                }
                else
                {

                    //verificar que alternan
                    bool no = false;
                    for (int i = 0; i < n - 1 && !no; i++)
                    {
                        if (serie[i] % 2 == serie[i + 1] % 2)
                        {
                            no = true;
                        }
                    }
                    if (no)
                        Console.WriteLine("NO");
                    else
                        Console.WriteLine("YES");
                }


            }

        }

    }

}