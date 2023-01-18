using System.Linq;
using System;

namespace codeforces.challengesA;

//133/A. HQ9+
public class problem133A
{

    public static void solution()
    {
        var program = Console.ReadLine();

        int ih = program.IndexOf('H');
        int iq = program.IndexOf('Q');
        int i9 = program.IndexOf('9');

        if (ih > -1 || iq > -1 || i9 > -1)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}

