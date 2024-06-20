using System.Linq;
using System;

namespace codeforces.challengesA;

//A2. Gardener and the Capybaras (hard version)
public class Problem1775A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var names = Console.ReadLine();

            int p = Array.FindIndex(names[1..^1].ToArray(), x => x == 'a');

            // System.Console.WriteLine($"p: {p} {new string(names[1..^1].AsSpan())}");
            string ans = string.Empty;
            if (p != -1)
            {
                p++;
                ans = names.Substring(0, p) + " " + names[p] + " " + names.Substring(p + 1);
            }
            else
            {
                ans = names[0] + " " + names.Substring(1, names.Length - 2) + " " + names[names.Length - 1];
            }

            System.Console.WriteLine(ans);
        }
    }
}


