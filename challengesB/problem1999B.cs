using System.Linq;
using System;

namespace codeforces.challengesB;

//B. Card Game
public class Problem1999B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var cards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            (int a1, int a2, int b1, int b2) = (cards[0], cards[1], cards[2], cards[3]);

            int wins = 0;
            if ((a1 > b1 && a2 >= b2) || (a1 >= b1 && a2 > b2)) wins++;
            if ((a1 > b2 && a2 >= b1) || (a1 >= b2 && a2 > b1)) wins++;
            if ((a2 > b1 && a1 >= b2) || (a2 >= b1 && a1 > b2)) wins++;
            if ((a2 > b2 && a1 >= b1) || (a2 >= b2 && a1 > b1)) wins++;

            Console.WriteLine(wins);
        }
    }
}


