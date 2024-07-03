using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Chat room
public class Problem58A
{

    public static void solution()
    {
        var s = Console.ReadLine();

        Stack<char> stack = new Stack<char>("hello".Reverse());

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == stack.Peek())
            {
                _ = stack.Pop();
                if (stack.Count == 0)
                    break;
            }
        }

        if (stack.Count == 0)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}


