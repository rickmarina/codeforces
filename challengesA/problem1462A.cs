using System.Linq;
using System;

namespace codeforces.challengesA
{
    //1462/A. Favorite Sequence
    public class problem1462A
    {

        public static void solution()
        {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var seq = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int p1 = 0;
                int p2 = seq.Length - 1;

                List<int> a = new List<int>();
                while (p1 < p2)
                {
                    a.Add(seq[p1++]);
                    a.Add(seq[p2--]);
                }
                if (p1 == p2)
                    a.Add(seq[p1]);

                Console.WriteLine($"{string.Join(" ", a)}");
            }

        }

    }

}