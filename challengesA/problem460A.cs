using System.Linq;
using System;

namespace codeforces.challengesA;

//460/A. Vasya and Socks
public class problem460A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = input[0], m = input[1];

        int total = n;
        while (n >= m)
        {
            total += (n / m);
            n = (n / m) + (n % m);
        }

        Console.WriteLine(total);
    }
}

