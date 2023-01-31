using System.Linq;
using System;

namespace codeforces.challengesA;

//1486/A. Shifting Stacks
public class problem1486A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            //minimal serie would be: 0, 1, 2, 3, 4
            //then we can store de extra blocks of each i-th stack and use it when needed

            long extra = 0;
            bool can = true;
            for (int i = 0; i < n; i++)
            {
                if (h[i] >= i)
                {
                    extra += h[i] - i;
                }
                else if (h[i] + extra >= i)
                {
                    extra -= i - h[i];
                }
                else
                {
                    can = false;
                    break;
                }
            }

            Console.WriteLine(can ? "YES" : "NO");

        }
    }
}

