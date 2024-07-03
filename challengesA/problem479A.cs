using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Expression
public class Problem479A
{

    public static void solution()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        int sum = 0;
        if (b == 1)
        {
            int maxac = Math.Max(a, c);
            if (maxac == 1)
                sum = (b + Math.Min(a, c)) + Math.Max(a, c);
            else
                sum = (b + Math.Min(a, c)) * Math.Max(a, c);
        }
        else if (a == 1)
        {
            sum = c == 1 ? (a + b + c) : (a + b) * c;
        }
        else if (c == 1)
        {
            sum = a * (b + c);
        }
        else
        {
            sum = a * b * c;
        }


        System.Console.WriteLine(sum);
    }
}


