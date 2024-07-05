using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Xenia and Ringroad
public class Problem339B
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        (int n, int m) = (input[0], input[1]); //n: #houses m: #tasks 

        var tasks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int current = 1;
        long moves = 0;
        //The ringroad traffic is one way
        foreach (var i in tasks)
        {
            if (i - current >= 0)
            {
                moves += i - current;
                current = i;
            }
            else
            {
                moves += i - current + n;
                current = i;
            }
        }

        System.Console.WriteLine(moves);
    }
}


