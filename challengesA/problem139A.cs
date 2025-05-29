using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Petr and Book
public class Problem139A
{

    public static void solution()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        var pages = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        decimal sum = pages.Sum();
        n = n - ((int)Math.Ceiling(n / sum) - 1) * sum;

        int i = 0;
        while (n > 0)
        {
            n -= pages[i++];
            if (i > pages.Length - 1 && n > 0)
                i = 0;
        }

        System.Console.WriteLine(i);

    }
}


