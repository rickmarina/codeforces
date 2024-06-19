using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Triangle
public class Problem6A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        (int a, int b, int c, int d) = (input[0], input[1], input[2], input[3]);

        //A triangle can be drawn only if the sum of any two sides of the triangle is greater than the third side
        if (TriPos(a, b, c) || TriPos(a, b, d) || TriPos(a, c, d) || TriPos(b, c, d))
            System.Console.WriteLine("TRIANGLE");
        else if (SegmentPos(a, b, c) || SegmentPos(a, b, d) || SegmentPos(a, c, d) || SegmentPos(b, c, d))
            System.Console.WriteLine("SEGMENT");
        else
            System.Console.WriteLine("IMPOSSIBLE");
    }
    static bool TriPos(int a, int b, int c) => b + c > a && a + c > b && a + b > c;
    static bool SegmentPos(int a, int b, int c) => a == b + c || b == a + c || c == a + b;
}


