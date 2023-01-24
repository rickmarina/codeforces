using System.Linq;
using System;

namespace codeforces.challengesB;

//1624/B. Make AP
public class problem1624B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int a = input[0], b = input[1], c = input[2]; //

            int m = -1;

            if ((2 * b - c) % a == 0 && (2 * b - c) > 0)
            {
                m = (2 * b - c) / a;
            }
            else if ((a + c) % (2 * b) == 0)
            {
                m = (a + c) / (2 * b);
            }
            else if ((2 * b - a) % c == 0 && (2 * b - a) > 0)
            {
                m = (2 * b - a) / c;
            }


            if (m == -1)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");

        }
    }
}

