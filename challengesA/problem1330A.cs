using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Dreamoon and Ranking Collection
public class Problem1330A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            (int n, int x) = (input[0], input[1]);

            var set = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet<int>();

            int i = 1;
            while (x > 0)
            {
                if (!set.Contains(i)) x--;
                i++;
            }
            while (set.Contains(i)) i++;
            i--;
            System.Console.WriteLine(i);
        }
    }
}


