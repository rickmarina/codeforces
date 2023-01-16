using System.Linq;
using System;

namespace codeforces.challengesC;

//1760/C. Advantage
public class problem1760C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int p = int.Parse(Console.ReadLine());

            var _s = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var s = _s.OrderBy(x => x).ToArray();

            var r = _s.Select(x => x == s[p - 1] ? x - s[p - 2] : x - s[p - 1]);
            Console.WriteLine(string.Join(" ", r));


        }
    }
}

