using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Road To Zero
public class Problem1342A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var inputXY = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            (long x, long y) = (inputXY[0], inputXY[1]);

            var inputAB = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            (long a, long b) = (inputAB[0], inputAB[1]);

            long mult = Math.Min(a * 2, b);

            long common = Math.Min(x, y) * mult;
            long rest = (Math.Max(x, y) - Math.Min(x, y)) * a;
            System.Console.WriteLine($"{common + rest}");

        }
    }
}


