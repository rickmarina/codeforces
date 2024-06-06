using System.Linq;
using System;

namespace codeforces.challengesD;

//D. Unnatural Language Processing
public class Problem1915D
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                char c = word[i];
                System.Console.Write(c);

                if ((c == 'a' || c == 'e') && i + 2 < n)
                {
                    if (word[i + 2] == 'a' || word[i + 2] == 'e')
                    {
                        System.Console.Write(".");
                    }
                    else
                    {
                        System.Console.Write($"{word[i + 1]}.");
                        i++;
                    }
                }
            }

            System.Console.WriteLine("");
        }
    }
}


