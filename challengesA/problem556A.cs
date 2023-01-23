using System.Linq;
using System;

namespace codeforces.challengesA;

//556A/A. Case of the Zeros and Ones
public class problem556A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var num = Console.ReadLine();

        int t1 = num.Count(x => x.Equals('1'));
        int t0 = num.Count(x => x.Equals('0'));

        Console.WriteLine(Math.Abs(t1 - t0));
    }
}

