using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Is it rated?
public class Problem807A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var ratings = Enumerable.Range(0, n).Select(x => Console.ReadLine().Split(' ').Select(int.Parse).ToArray()).ToArray();

        bool rated = false;
        bool unrated = false;
        int max = ratings[0][0];
        for (int i = 0; i < n; i++)
        {
            if (ratings[i][0] != ratings[i][1])
            {
                rated = true;
                break;
            }
            if (max < ratings[i][0])
            {
                unrated = true;
            }
            max = ratings[i][0];
        }

        if (rated)
            System.Console.WriteLine("rated");
        else if (unrated)
            System.Console.WriteLine("unrated");
        else
            System.Console.WriteLine("maybe");
    }
}


