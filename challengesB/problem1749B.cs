using System.Linq;
using System;

namespace codeforces.challengesA;

//1749/B. Death's Blessing
public class problem1749B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            long n = long.Parse(Console.ReadLine());  //# monster in the row

            var a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            var s = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            long i = 0;
            long j = n - 1;
            long totalTime = 0;

            if (n == 1)
            {
                totalTime = a[0];
            }
            else
            {
                while (i <= j)
                {
                    if (s[i] <= s[j])
                    {
                        totalTime += a[i];
                        if (i < j)
                            a[i + 1] += s[i];
                        i++;
                    }
                    else if (s[j] < s[i])
                    {
                        totalTime += a[j];
                        if (j > i)
                            a[j - 1] += s[j];
                        j--;
                    }
                }
            }

            Console.WriteLine($"{totalTime}");
        }
    }
}


