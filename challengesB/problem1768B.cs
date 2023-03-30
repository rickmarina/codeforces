using System.Linq;
using System;

namespace codeforces.challengesB;

//1768/B. Quick Sort
public class problem1768B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = dat[0], k = dat[1];

            var p = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int serie = 1;
            int total = 0; //unordered elements
                           //because we know that is a permutation [1,2,3,...,n] all numbers are distinct <= n
            for (int i = 0; i < n; i++)
            {
                if (p[i] == serie)
                {
                    serie++;
                }
                else
                {
                    total++;
                }
            }

            Console.WriteLine((total + k - 1) / k);
        }
    }
}




