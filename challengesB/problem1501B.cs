using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Napoleon Cake
public class Problem1501B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int pour = a.Last();
            Stack<int> napoleon = new();

            for (int i = a.Length - 1; i >= 0; i--)
            {
                pour = Math.Max(pour, a[i]);
                napoleon.Push(Math.Clamp(pour, 0, 1));

                pour--;
            }

            Console.WriteLine(string.Join(' ', napoleon));
        }
    }
}


