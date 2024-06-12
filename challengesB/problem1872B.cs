using System.Linq;
using System;

namespace codeforces.challengesB;

//B. The Corridor or There and Back Again
public class Problem1872B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine()); // # traps 

            int k = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                var trap = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                k = Math.Min(k, trap[0] + ((int)Math.Ceiling(trap[1] / 2.0) - 1));

            }

            System.Console.WriteLine(k);
        }
    }
}


