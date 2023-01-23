using System.Linq;
using System;

namespace codeforces.challengesA;

//474/A. Keyboard
public class problem474A
{

    public static void solution()
    {
        string keyboard = @"qwertyuiopasdfghjkl;zxcvbnm,./";
        string dir = Console.ReadLine();

        string text = Console.ReadLine();

        var result = text.Select(x => dir.Equals("R") ? keyboard[keyboard.IndexOf(x) - 1] : keyboard[keyboard.IndexOf(x) + 1]);

        Console.WriteLine(string.Concat(result));
    }
}

