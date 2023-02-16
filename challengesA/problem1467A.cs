using System.Linq;
using System;

namespace codeforces.challengesA;

//1467/A. Wizard of Orz
public class problem1467A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var r = string.Join("", Enumerable.Range(0, n).Select(x =>
            {
                if (x == 0) return 9;
                else if (x == 1) return 8;
                else if (x == 2) return 9;
                else return ((x - 3) % 10);

            }));

            Console.WriteLine(r);

        }
    }
}

