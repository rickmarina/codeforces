using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Young Physicist
public class Problem69A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        int sx = 0, sy = 0, sz = 0;

        for (int i = 0; i < n; i++)
        {
            var forces = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            sx += forces[0];
            sy += forces[1];
            sz += forces[2];
        }

        if (sx + sy + sz != 0)
            System.Console.WriteLine("NO");
        else
            System.Console.WriteLine("YES");
    }
}


