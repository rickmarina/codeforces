using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Mahmoud and a Triangle
public class Problem766B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        var segments = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();

        bool possible = false;
        for (int i = 0; i < n - 2; i++)
        {
            (int x, int y, int z) = (segments[i], segments[i + 1], segments[i + 2]);
            if (x + y > z && x + z > y && y + z > x)
            {
                possible = true;
                break;
            }
        }

        if (possible)
            System.Console.WriteLine("YES");
        else
            System.Console.WriteLine("NO");
    }
}


