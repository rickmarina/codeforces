using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Not a Substring
public class Problem1860A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            string s = Console.ReadLine();

            if (s == "()")
            {
                System.Console.WriteLine("NO");
                continue;
            }

            System.Console.WriteLine("YES");

            string r1 = new string('(', s.Length) + new string(')', s.Length);
            string r2 = string.Join("", Enumerable.Range(0, s.Length).Select(x => "()"));

            Console.WriteLine(r1.IndexOf(s) != -1 ? r2 : r1);
        }
    }
}


