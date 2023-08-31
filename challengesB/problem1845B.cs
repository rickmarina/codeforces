using System.Linq;
using System;

namespace codeforces.challengesB;

//1845/B. Come Together
public class problem1845B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            var bob = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            var carol = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            long common = 1;
            if (bob[1] > a[1] && carol[1] > a[1])
                common += Math.Abs(Math.Min(bob[1], carol[1]) - a[1]);
            else if (bob[1] < a[1] && carol[1] < a[1])
                common += Math.Abs(Math.Max(bob[1], carol[1]) - a[1]);

            if (bob[0] > a[0] && carol[0] > a[0])
                common += Math.Abs(Math.Min(bob[0], carol[0]) - a[0]);
            else if (bob[0] < a[0] && carol[0] < a[0])
                common += Math.Abs(Math.Max(bob[0], carol[0]) - a[0]);

            Console.WriteLine($"{common}");
        }
    }
}


