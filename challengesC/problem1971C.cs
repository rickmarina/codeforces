using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Clock and Strings
public class Problem1971C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int a, int b, int c, int d) = (input[0], input[1], input[2], input[3]);

            // line 1: a -> b
            // line 2: c -> d

            if (Math.Max(a, b) > c && c > Math.Min(a, b) && (d > Math.Max(a, b) || d < Math.Min(a, b)))
            {
                Console.WriteLine("YES");
            }
            else if (Math.Max(a, b) > d && d > Math.Min(a, b) && (c > Math.Max(a, b) || c < Math.Min(a, b)))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}


