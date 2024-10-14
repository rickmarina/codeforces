using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Arpa’s hard exam and Mehrdad’s naive cheat
public class Problem742A
{

    public static void solution()
    {
        Dictionary<int, int> precalc = new Dictionary<int, int>() { { 1, 8 }, { 2, 4 }, { 3, 2 }, { 0, 6 } };

        int n = int.Parse(Console.ReadLine());

        if (n == 0)
            System.Console.WriteLine("1");
        else
        {
            int r = n % 4;
            System.Console.WriteLine($"{precalc[r]}");
        }
    }
}


