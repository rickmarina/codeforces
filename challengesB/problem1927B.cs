using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Following the String
public class Problem1927B
{

    public static void solution()
    {
        string abc = "abcdefghijklmnopqrstuvwxyz";

        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] count = new int[abc.Length];
            int[] trace = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            foreach (var t in trace)
            {
                int idx = Array.FindIndex(count, x => x == t);
                count[idx]++;
                Console.Write(abc[idx]);
            }
            Console.WriteLine();
        }

    }
}


