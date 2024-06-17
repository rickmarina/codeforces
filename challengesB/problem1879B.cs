using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Chips on the Board
public class Problem1879B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine()); 
        while (tc-- > 0) {
            int n = int.Parse(Console.ReadLine());

            var a = Console.ReadLine().Split(' ').Select(long.Parse).OrderBy(x => x).ToArray();
            var b = Console.ReadLine().Split(' ').Select(long.Parse).OrderBy(x => x).ToArray();

            long sumA = a.Sum();
            long sumB = b.Sum();

            long min = Math.Min((a[0] * n) + sumB, (b[0] * n) + sumA);

            Console.WriteLine(min);
        }
    }
}


