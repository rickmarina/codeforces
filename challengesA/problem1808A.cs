using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Lucky Numbers
public class Problem1808A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int l, int r) = (input[0], input[1]);

            int max = 0;
            int luckiest = l;
            for (int i = r; i >= l; i--)
            {
                int maxDigit = i.ToString().Select(x => int.Parse(x.ToString())).Max(x => x);
                int minDigit = i.ToString().Select(x => int.Parse(x.ToString())).Min(x => x);

                int diff = maxDigit - minDigit;
                if (diff > max)
                {
                    luckiest = i;
                    max = diff;
                }

                if (diff == 9)
                    break;
                // System.Console.WriteLine($"num {i} max: {maxDigit} min: {minDigit}");
            }
            System.Console.WriteLine($"{luckiest}");
        }
    }
}


