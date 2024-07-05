using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Raising Bacteria
public class Problem579A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        int ans = 0;
        while (n > 0)
        {
            if ((n & 1) == 1)
                ans++;

            n >>= 1;
        }

        System.Console.WriteLine(ans);
    }
}


