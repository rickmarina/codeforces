using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1369/A. FashionabLee
    public class problem1369A
    {

        public static void solution()
        {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                decimal sides = decimal.Parse(Console.ReadLine());

                if (sides % 4 == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }

    }

}