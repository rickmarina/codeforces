using System.Linq;
using System;

namespace codeforces.challengesA;

//129/A. Cookies
public class problem129A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine()); //# cookie bags

        var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); //# cookies in the ith bag

        long totalCookies = a.Sum();

        int totalOlga = 0;
        for (int i = 0; i < n; i++)
        {
            if ((totalCookies - a[i]) % 2 == 0)
                totalOlga++;
        }

        Console.WriteLine($"{totalOlga}");
    }
}


