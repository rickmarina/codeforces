using System.Linq;
using System;

namespace codeforces.challengesA;

//1295/A. Display The Number
public class problem1295A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string ans = string.Empty;

            if (n % 2 == 1 && n >= 3)
            {
                ans += "7"; n -= 3;
            }

            while (n > 1 && n % 2 == 0)
            {
                ans += "1";
                n -= 2;
            }

            Console.WriteLine(ans);
        }

    }
}

