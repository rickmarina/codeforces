using System.Linq;
using System;

namespace codeforces.challengesB;

//1537/B. Bad Boy
public class problem1537B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0], m = input[1], i = input[2], j = input[3];

            //bottom left or right
            int y1 = n;
            int x1 = 1 == j ? m : 1;

            //top right or left
            int y2 = 1;
            int x2 = m == j ? 1 : m;

            Console.WriteLine($"{y1} {x1} {y2} {x2}");
        }
    }
}

