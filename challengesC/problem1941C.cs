using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Rudolf and the Ugly String
public class Problem1941C
{

    public static void solution()
    {
        //count map|pie ocurrences in string using regex and not possitive lookahead pattern

        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            int total = Regex.Matches(str, "map|pie").Count();

            System.Console.WriteLine($"{total}");
        }
    }
}


