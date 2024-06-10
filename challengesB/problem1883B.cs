using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Chemistry
public class Problem1883B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            (int n, int k) = (input[0], input[1]);

            string s = Console.ReadLine();

            var groups = s.GroupBy(x => x).Select(g => new { k = g.Key, v = g.Count() });
            int odd = groups.Where(x => (x.v % 2) != 0).Count();

            // foreach (var g in groups) { 
            //     Console.WriteLine($"{g.k} {g.v}");
            // }

            // Console.WriteLine($"min odd: {odd} k: {k}");

            if (k >= odd - 1)
                Console.WriteLine($"YES");
            else
                Console.WriteLine($"NO");
        }
    }
}


