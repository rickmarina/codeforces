using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Theatre Square
public class Problem1A
{
    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        (decimal n, decimal m, decimal a) = (input[0], input[1], input[2]);

        decimal horizontal = Math.Ceiling(n / a);
        decimal vertical = Math.Ceiling(m / a);

        Console.WriteLine(horizontal * vertical);
    }
}