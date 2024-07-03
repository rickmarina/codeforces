using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Lucky Division
public class Problem122A
{

    public static void solution()
    {
        int[] lucky = new int[] { 4, 7, 44, 47, 77, 444, 777, 447, 474, 744, 477, 747, 774 };

        int n = int.Parse(Console.ReadLine());

        if (lucky.Any(x => n % x == 0))
            System.Console.WriteLine("YES");
        else
            System.Console.WriteLine("NO");
    }
}


