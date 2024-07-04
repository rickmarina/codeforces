using System.Linq;
using System;

namespace codeforces.challengesA;

//A. cAPS lOCK
public class Problem131A
{

    public static void solution()
    {
        string s = Console.ReadLine();

        int totalUpper = s.Count(x => char.IsUpper(x));

        if ((s.Length == totalUpper) || (s.Length - 1 == totalUpper && char.IsLower(s[0])))
        {
            s = string.Join("", s.Select(x => char.IsUpper(x) ? x.ToString().ToLower() : x.ToString().ToUpper()));
        }

        System.Console.WriteLine(s);
    }
}


