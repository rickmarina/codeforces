using System.Linq;
using System;

namespace codeforces.challengesB;

//1747/B. BAN BAN
public class problem1747B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var n = int.Parse(Console.ReadLine());
            //we can calculate total moves using this formula: 
            // moves > ( 3*n -2 ) / 6
            double total = Math.Ceiling((3 * n - 2) / 6.0);
            Console.WriteLine(total);
            for (int t = 0; t < total; t++)
            {
                Console.WriteLine($"{2 + t * 3} {3 * n - 3 * t}");
            }

            /*
            int i = 2;
            int j = 3 * n;
            var moves = new List<string>();

            while (i < j)
            {
                moves.Add($"{i} {j}");
                i += 3;
                j -= 3;
            }

            Console.WriteLine(moves.Count);
            moves.ForEach(x => { Console.WriteLine(x); });
            */
        }
    }
}




