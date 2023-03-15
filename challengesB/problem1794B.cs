using System.Linq;
using System;

namespace codeforces.challengesB;

//1794/B. Not Dividing
public class problem1794B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            if (a[0] == 1) a[0]++; //all 1s are replaced by 2
            int i = 1;

            while (i < n)
            {
                if (a[i] == 1) //all 1s are replaced by 2
                    a[i]++;

                if (a[i] % a[i - 1] == 0)
                    a[i]++;

                i++;
            }

            Console.WriteLine(string.Join(" ", a));
        }
    }
}

