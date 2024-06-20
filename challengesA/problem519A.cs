using System.Linq;
using System;

namespace codeforces.challengesA;

//A. A and B and Chess
public class Problem519A
{

    public static void solution()
    {
        Dictionary<char, int> weights = new Dictionary<char, int>() {
            {'Q', 9},
            {'R', 5},
            {'B', 3},
            {'N', 3},
            {'P', 1},
            {'K', 0}
        };

        int totalWhite = 0, totalBlack = 0;

        for (int i = 0; i < 8; i++)
        {
            string board = Console.ReadLine();

            totalWhite += board.Where(x => char.IsUpper(x)).Select(x => x != '.' ? weights[x] : 0).Sum();
            totalBlack += board.Where(x => !char.IsUpper(x)).Select(x => x != '.' ? weights[char.ToUpper(x)] : 0).Sum();
            // System.Console.WriteLine($"totalW {totalWhite} totalB {totalBlack}");
        }
        if (totalWhite > totalBlack)
            System.Console.WriteLine("White");
        else if (totalBlack > totalWhite)
            System.Console.WriteLine("Black");
        else
            System.Console.WriteLine("Draw");
    }
}


