using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Fireworks
public class Problem1945B
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            (long freq1, long freq2, long timeVisible) = (input[0], input[1], input[2]);

            long total1 = (freq1 + timeVisible) / freq1;
            long total2 = (freq2 + timeVisible) / freq2;

            System.Console.WriteLine($"{total1 + total2}");
        }
    }
}


