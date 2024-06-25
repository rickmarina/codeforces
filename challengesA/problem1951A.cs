using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Dual Trigger
public class Problem1951A
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();

            List<int> indexOne = new();
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 1)
                    indexOne.Add(i);
            }

            if (indexOne.Count % 2 != 0)
            {
                System.Console.WriteLine("NO");
            }
            else if (indexOne.Count == 2 && (indexOne[1] - indexOne[0] == 1))
            {
                System.Console.WriteLine("NO");
            }
            else
            {
                System.Console.WriteLine("YES");
            }

        }
    }
}


