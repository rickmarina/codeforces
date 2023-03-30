using System.Linq;
using System;

namespace codeforces.challengesB;

//1005/B. Delete from the Left
public class problem1005B
{

    public static void solution()
    {
        var s = Console.ReadLine();
        var t = Console.ReadLine();

        int eq = 0;
        while (eq <= Math.Min(s.Length, t.Length) - 1 && s[s.Length - eq - 1] == t[t.Length - eq - 1])
        {
            eq++;
        }
        // Console.WriteLine("eq: "+eq);

        int ans = (s.Length - eq) + (t.Length - eq);
        Console.WriteLine(ans);
    }
}




