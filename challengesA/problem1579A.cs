using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1579/A. Casimir's String Solitaire
    public class problem1579A
    {

        public static void solution()
        {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {

                string cad = Console.ReadLine();

                var totals = cad.OrderBy(o => o).GroupBy(x => x).Select(g => new KeyValuePair<char, int>(g.Key, g.Count())).ToList();

                int totalA = totals.Where(x => x.Key == 'A').Select(x => x.Value).FirstOrDefault();
                int totalB = totals.Where(x => x.Key == 'B').Select(x => x.Value).FirstOrDefault();
                int totalC = totals.Where(x => x.Key == 'C').Select(x => x.Value).FirstOrDefault();

                if (totalB - totalA == totalC)
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