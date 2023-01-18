using System.Linq;
using System;

namespace codeforces.challengesA;

//96/A. Football
public class problem96A
{

    public static void solution()
    {
        var situation = Console.ReadLine();
        var prev = situation[0];
        int total = 1;

        bool dangerous = false;
        for (int i = 1; i < situation.Length; i++)
        {
            if (situation[i].Equals(prev))
                total++;
            else
            {
                total = 1;
                prev = situation[i];
            }
            if (total >= 7)
            {
                dangerous = true;
                break;
            }
        }

        Console.WriteLine(dangerous ? "YES" : "NO");
    }
}

