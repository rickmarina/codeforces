using System.Linq;
using System;

namespace codeforces.challengesB;

//1650/B. DIV + MOD
public class problem1650B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int l = input[0], r = input[1], a = input[2];

            int d = r / a;
            int m = r % a;
            int result = d + m;
            int prev = (d - 1) * a + (a - 1);

            if (prev >= l)
            {
                int aux = (d - 1) + (a - 1);
                result = (result > aux) ? result : aux;

            }

            Console.WriteLine(result);
        }
    }
}

