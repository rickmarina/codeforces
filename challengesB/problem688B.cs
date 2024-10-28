using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Lovely Palindromes
public class Problem688B
{

    public static void solution()
    {
        string n = Console.ReadLine();

        string rev = new String(n.Reverse().ToArray());
        string ans = n + rev;
        System.Console.WriteLine(ans);
    }
}


