using System.Linq;
using System;

namespace codeforces.challengesB;

//1733/B. Rule of League
public class problem1733B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = dat[0]; //# players 
            int x = dat[1]; //# x wins
            int y = dat[2]; //# y wins

            if ((x > 0 && y > 0) || (x == 0 && y == 0))
            {
                Console.WriteLine("-1");
            }
            else
            {
                //x or y is 0

                if (x == 0)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                if ((n - 1) % x == 0)
                {
                    int temp = (n - 1) / x;
                    print(temp, x);
                }
                else
                    Console.WriteLine("-1");

            }
        }
    }

    static void print(int temp, int x)
    {
        int c = 1;
        while (temp-- > 0)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{c} ");
            }
            if (c == 1)
                c++;
            c += x;
        }

        Console.WriteLine();
    }
}


