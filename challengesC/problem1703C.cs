using System.Linq;
using System;

namespace codeforces.challengesC
{

    //1703/C. Cypher
    public class problem1703C
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());

                var digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                List<int> movesdigits = new List<int>();
                for (int m = 0; m < n; m++)
                {
                    var moves = Console.ReadLine().Split(" ");
                    var nummoves = int.Parse(moves[0]);
                    var suma = moves[1].Select(x => x == 'D' ? 1 : -1).Sum();
                    if (suma < 0) suma = 10 + suma;
                    movesdigits.Add((digits[m] + suma) % 10);
                }

                Console.WriteLine(string.Join(" ", movesdigits));
            }

        }

    }

}