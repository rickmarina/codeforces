using System.Linq;
using System;

namespace codeforces.challengesA;

//320/A. Magic Numbers
public class problem320A
{

    public static void solution()
    {
        var n = Console.ReadLine();


        bool magic = true;
        if (n[0] != '1')
            magic = false;

        if (n.Length == 2)
        {
            if (!n.Equals("11") && !n.Equals("14"))
            {
                magic = false;
            }
        }
        else
        {
            for (int i = 2; i < n.Length; i++)
            {
                if (n[i] == '4')
                {
                    if (!(n[i - 1] == '4' && n[i - 2] == '1') && !(n[i - 1] == '1'))
                    {
                        magic = false;
                    }
                }
                else if (n[i] != '1')
                {
                    magic = false;
                }
            }
        }

        Console.WriteLine(magic ? "YES" : "NO");
    }
}

