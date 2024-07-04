using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Dragons
public class Problem230A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        (int s, int n) = (input[0], input[1]);

        var dragons = Enumerable.Range(0, n).Select(x => Console.ReadLine().Split(' ').Select(int.Parse).ToArray()).OrderBy(x => x[0]).ToArray();

        bool nextlevel = true;
        for (int i = 0; i < n; i++)
        {
            if (s > dragons[i][0])
            {
                s += dragons[i][1];
            }
            else
            {
                nextlevel = false;
                break;
            }
        }

        if (nextlevel)
            System.Console.WriteLine("YES");
        else
            System.Console.WriteLine("NO");
    }
}


