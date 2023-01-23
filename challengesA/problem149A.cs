using System.Linq;
using System;

namespace codeforces.challengesA;

//149/A. Business trip
public class problem149A
{

    public static void solution()
    {
        int k = int.Parse(Console.ReadLine()); //min cm 

        var grows = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(o => o).ToArray();
        if (grows.Sum() < k)
        {
            Console.WriteLine("-1");
            return;
        }

        int cm = 0;
        int i = 0;
        while (cm < k && i < grows.Length)
        {
            cm += grows[i];
            i++;
        }

        Console.WriteLine(i);
    }
}

