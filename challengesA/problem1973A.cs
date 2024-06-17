using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Chess For Three
public class Problem1973A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            (int a, int b, int c) = (input[0], input[1], input[2]);

            int sum = input.Sum();

            if (sum % 2 != 0)
                System.Console.WriteLine("-1");
            else
            {
                int r = Math.Min(sum / 2, (a + b));
                System.Console.WriteLine(r);
            }
        }
    }
}


