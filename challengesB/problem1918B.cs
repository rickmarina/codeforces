using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Minimize Inversions
public class Problem1918B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var p1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var map = p1.Select((x, i) => new { k = x, v = p2[i] }).ToDictionary(x => x.k);

            var p1o = p1.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(' ', p1o));
            Console.WriteLine(string.Join(' ', p1o.Select(x => map[x].v)));
        }
    }
}


