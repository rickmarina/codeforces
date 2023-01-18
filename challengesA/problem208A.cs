using System.Linq;
using System;

namespace codeforces.challengesA;

//208/A. Dubstep
public class problem208A
{

    public static void solution()
    {
        var song = Console.ReadLine().Split("WUB");

        var r = song.Where(x => !x.Equals("")).Select(x => x).ToArray();

        Console.WriteLine(string.Join(" ", r));
    }
}

