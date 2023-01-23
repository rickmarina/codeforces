using System.Linq;
using System;

namespace codeforces.challengesB;

//1335/B. Construct the String
public class problem1335B
{

    public static void solution()
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";

        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0], a = input[1], b = input[2]; //len, substring, distinct letters

            var len = letters.Substring(0, b);

            var r = Enumerable.Repeat(len, (n / b) + 1);

            Console.WriteLine(string.Concat(r).Substring(0, n));


        }
    }
}

