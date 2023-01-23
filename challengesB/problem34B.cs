using System.Linq;
using System;

namespace codeforces.challengesB;

//34/B. Sale
public class problem34B
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = input[0], m = input[1]; //tv sets, can carry

        var prices = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        var result = prices.Where(p=> p<0).OrderBy(x=> x).Take(m);

        Console.WriteLine(Math.Abs(result.Sum()));
    }
}

