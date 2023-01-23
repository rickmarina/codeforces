using System.Linq;
using System;

namespace codeforces.challengesB;

//977/B. Two-gram
public class problem977B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        int max = 0;
        string twogram = "";

        for (int i = 0; i < n - 1; i++)
        {
            var r = IndexOfAll(str, str.Substring(i, 2));
            if (r > max)
            {
                max = r;
                twogram = str.Substring(i, 2);
            }
        }

        Console.WriteLine(twogram);
    }

    static int IndexOfAll(string sourceString, string subString)
    {
        int pos = -1, count = 0;

        while ((pos = sourceString.IndexOf(subString, pos + 1)) != -1)
        {
            count++;
        }

        return count;
    }
}

