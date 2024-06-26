using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace codeforces.challengesA;

//A. Sushi for Two
public class Problem1138A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine().Replace(" ", "");

        var matches12 = Regex.Matches(s, "1+2+");

        int min = 0;
        foreach (Match m in matches12)
        {
            min = Math.Max(min, Math.Min(m.Value.Count(x => x == '1'), m.Value.Count(x => x == '2')));
        }

        var matches21 = Regex.Matches(s, "2+1+");
        foreach (Match m in matches21)
        {
            min = Math.Max(min, Math.Min(m.Value.Count(x => x == '1'), m.Value.Count(x => x == '2')));
        }


        System.Console.WriteLine(min * 2);
    }
}


