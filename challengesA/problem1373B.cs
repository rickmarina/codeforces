using System.Linq;
using System;

namespace codeforces.challengesB;

//1373/B. 01 Game
public class problem1373B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        //Console.WriteLine("11001".Substring(0,3));
        //Console.WriteLine("11001".Substring(4));

        while (tc-- > 0)
        {
            var bin = Console.ReadLine();

            int turn = 0;

            while (bin.IndexOf("01") > -1 || bin.IndexOf("10") > -1)
            {

                int pos1 = bin.IndexOf("01");
                if (pos1 == -1)
                    pos1 = bin.IndexOf("10");

                bin = bin.Substring(0, pos1) + bin.Substring(pos1 + 2);
                turn++;
            }

            Console.WriteLine(turn % 2 == 1 ? "DA" : "NET");

        }
    }
}

