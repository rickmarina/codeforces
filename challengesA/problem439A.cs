using System.Linq;
using System;

namespace codeforces.challengesA;

//439/A. Devu, the Singer and Churu, the Joker
public class problem439A
{

    public static void solution()
    {
        var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = dat[0], d = dat[1]; //n songs, d event duration 

        var t = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int totalT = t.Sum() + (t.Length - 1) * 10;
        int totalJ = 0;
        if (totalT > d)
        {
            Console.WriteLine("-1");
        }
        else
        {
            totalJ = (t.Length - 1) * 2 + (d - totalT) / 5;
            Console.WriteLine(totalJ);

        }
    }
}

