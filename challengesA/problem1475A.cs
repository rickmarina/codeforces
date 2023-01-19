using System.Linq;
using System;

namespace codeforces.challengesA;

//1475/A. Odd Divisor
public class problem1475A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {

            long num = long.Parse(Console.ReadLine());

            if ((num & 1) == 1)
                Console.WriteLine("YES");
            else
            {
                while (num > 1)
                {
                    if (num % 2 == 1)
                        break;
                    num = num / 2;
                }
                if (num > 1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");

                }
            }


        }

    }
}

