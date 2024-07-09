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

            Stack<char> stack = new();
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                    stack.Push('(');
                else
                {
                    if (stack.Count == 0)
                        ans++;
                    else
                        stack.Pop();
                }

            }

            System.Console.WriteLine(ans);
        }
    }
}


