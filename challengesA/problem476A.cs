using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Dreamoon and Stairs
public class Problem476A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //n steps
        //m divisible by
        (int n, int m) = (input[0], input[1]);

        int ans = 0;
        if (n < m)
        {
            ans = -1;
        }
        else
        {
            if (n % 2 == 0)
                ans = n / 2;
            else
                ans = n / 2 + 1;

            while (ans % m != 0)
                ans++;
        }

        System.Console.WriteLine(ans);
    }
}


