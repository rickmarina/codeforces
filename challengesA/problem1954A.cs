using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Painting the Ribbon
public class Problem1954A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            (double partsTotal, double colors, double partBob) = (input[0], input[1], input[2]);

            if (colors == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                double r = Math.Floor(partsTotal - (partsTotal / colors));
                if (r > partBob)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }

        }
    }
}


