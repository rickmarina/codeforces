using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Lecture
public class Problem499B
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        (long n, long m) = (input[0], input[1]);

        Dictionary<string, string> lang = new();
        for (int i = 0; i < m; i++)
        {
            var words = Console.ReadLine().Split(' ');
            lang[words[0]] = words[1];
        }

        var text = Console.ReadLine().Split(' ');

        List<string> output = new();

        foreach (var w in text)
        {
            if (w.Length <= lang[w].Length)
                output.Add(w);
            else
                output.Add(lang[w]);
        }
        System.Console.WriteLine($"{string.Join(" ", output)}");
    }
}


