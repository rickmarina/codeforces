using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Football
public class Problem43A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var goals = Enumerable.Range(0, n).Select(x => Console.ReadLine()).GroupBy(x => x).Select(g => new { k = g.Key, v = g.Count() }).OrderBy(x => x.v);
        string ans = goals.Last().k;

        System.Console.WriteLine(ans);
    }
}


