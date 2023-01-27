using System.Linq;
using System;

namespace codeforces.challengesA;

//1324/A. Yet Another Tetris Problem
public class problemn1324A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int max = a.Max();

            if (a.Any(x => (max - x) % 2 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");

            }

        }
    }
}

