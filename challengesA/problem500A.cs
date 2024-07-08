using System.Linq;
using System;

namespace codeforces.challengesA;

//A. New Year Transportation
public class Problem500A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //n #cells 
        //t destination 
        (int n, int t) = (input[0], input[1]);

        var world = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        HashSet<int> cellsSeen = new();

        Queue<int> queue = new();
        queue.Enqueue(1);

        bool possible = false;
        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            if (current > n - 1)
                break;

            int next = current + world[current - 1];
            if (next == t)
            {
                possible = true;
                break;
            }
            if (!cellsSeen.Add(next))
            {
                break;
            }

            queue.Enqueue(next);
        }


        Console.WriteLine(possible ? "YES" : "NO");
    }
}


