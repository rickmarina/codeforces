using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Shooting
public class Problem1216B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        var cans = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var orderedcans = cans.Select((x, i) => new { dur = x, idx = i }).OrderByDescending(x => x.dur).ToArray();

        int total = Enumerable.Range(0, n).Select((x, i) => (orderedcans[i].dur * i) + 1).Sum();

        System.Console.WriteLine($"{total}");
        System.Console.WriteLine(string.Join(" ", orderedcans.Select(x => x.idx + 1)));
    }
}


