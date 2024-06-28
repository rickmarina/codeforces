using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Reversing Encryption
public class Problem999B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        //Calc divisors from 1 to n 
        var divisors = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();

        foreach (var m in divisors)
        {
            string t = "";
            for (int j = 0; j < m; j++)
                t += s[j];

            int k = m - 1;
            for (int j = 0; j < m; j++)
            {
                s = s.Remove(j, 1).Insert(j, t[k].ToString());
                k--;
            }
        }

        Console.WriteLine(s);
    }
}


