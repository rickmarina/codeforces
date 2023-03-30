using System.Linq;
using System;

namespace codeforces.challengesA;

//1496/A. Split it!
public class problem1496A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = dat[0], k = dat[1]; // n len of string, k
            var s = Console.ReadLine();

            // Console.WriteLine(s.Substring(0, n / 2));
            // Console.WriteLine(s.Substring((n / 2) + 1));
            bool valid = true;

            if (2 * k >= n)
                valid = false;
            else
            {
                for (int i = 0; i < k && valid; i++)
                {
                    if (!s[i].Equals(s[n - 1 - i]))
                        valid = false;
                }

            }

            Console.WriteLine(valid ? "YES" : "NO");
        }
    }
}




