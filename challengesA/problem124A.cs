using System.Linq;
using System;

namespace codeforces.challengesA;

//A. The number of positions
public class Problem124A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        (int n, int a, int b) = (input[0], input[1], input[2]);

        int front = (n - a);
        int back = (b + 1);

        System.Console.WriteLine(Math.Min(front, back));
    }
}


