using System.Linq;
using System;

namespace codeforces.challengesA;

//1391/A. Suborrays
public class problem1391A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            long n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}

