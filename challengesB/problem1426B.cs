using System.Linq;
using System;

namespace codeforces.challengesB;

//1426/B. Symmetric Matrix
public class problem1426B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {

            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int n = dat[0], m = dat[1]; //n: # tiles m: size square

            bool diagonal = false;
            for (int t = 0; t < n; t++)
            {
                var tile = Enumerable.Range(0, 2).Select(x => Console.ReadLine().Split(" ")).ToArray();
                if ((tile[0][1] == tile[1][0]) && !diagonal)
                    diagonal = true;
            }

            if ((m % 2 != 0) || (m < 2))
                diagonal = false;

            if (diagonal)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


        }
    }
}




