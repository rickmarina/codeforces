using System.Linq;
using System;

namespace codeforces.challengesA;

//A. String Task
public class Problem118A
{

    public static void solution()
    {
        List<char> vowels = new() { 'a', 'o', 'y', 'e', 'u', 'i' };

        string text = Console.ReadLine();

        var ans = text.ToLower().Select(x => vowels.Any(v => v == x) ? "" : $".{x}");

        System.Console.WriteLine(string.Join("", ans));
    }
}


