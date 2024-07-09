using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Move Brackets
public class Problem1374C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int count = 0;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                    count++;
                else
                    count--;

                if (count < 0)
                {
                    count = 0;
                    ans++;
                }
            }

            System.Console.WriteLine(ans);


        }
    }
}


