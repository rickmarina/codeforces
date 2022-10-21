using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1097/A. Gennady and a Card Game
    public class problem1097A
    {

        public static void solution()
        {

            string table = Console.ReadLine();

            var hand = Console.ReadLine().Split(" ");

            bool anySuitRank = hand.Any(x => x[0] == table[0] || x[1] == table[1]);

            if (anySuitRank)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

    }

}