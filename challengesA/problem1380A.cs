using System.Linq;
using System;

namespace codeforces.challengesA;

//1380/A. Three Indices
public class problem1380A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var p = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int x = -1, y = -1, z = -1;
            for (int i = 1; i < n - 1; i++)
            {
                if ((p[i - 1] < p[i]) && (p[i] > p[i + 1]))
                {
                    x = i - 1;
                    y = i;
                    z = i + 1;
                    break;
                }
            }

            if (x == -1)
                Console.WriteLine("NO");
            else
            {
                Console.WriteLine("YES");
                Console.WriteLine($"{x + 1} {y + 1} {z + 1}");

            }

        }
    }
}

