using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Olesya and Rodion
public class Problem584A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //n digits
        //t divisible by
        (int n, int t) = (input[0], input[1]);


        if (t.ToString().Length > n)
            System.Console.WriteLine("-1");
        else
            System.Console.WriteLine(t.ToString() + new string('0', n - t.ToString().Length));
    }
}


