using System.Linq;
using System;

namespace codeforces.challengesA;

//1401/A. Distance and Axis
public class problem1401A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0], k = input[1];

            int ans = 0;
            if (k >= n)
            {
                ans = k - n;
            }
            else
            {
                ans = (n % 2) ^ (k % 2); //if modules are different -> 1
                //if (n%2 != k%2) 
                //    ans =1;
            }

            Console.WriteLine(ans);

        }
    }
}

