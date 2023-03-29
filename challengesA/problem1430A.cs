using System.Linq;
using System;

namespace codeforces.challengesA;

//1430/A. Number of Apartments
public class problem1430A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0, y = 0, z = 0;
            if (n % 7 == 0)
                z = n / 7;
            else if (n % 5 == 0)
                y = n / 5;
            else if (n % 3 == 0)
                x = n / 3;
            else
            {
                bool found = false;
                for (int i = 0; i <= 1000 / 7 && !found; i++)
                {
                    int rest = n - (7 * i);
                    for (int j = 0; j < 1000 / 5 && !found; j++)
                    {
                        rest = rest - (5 * j);
                        if (rest >= 0 && rest % 3 == 0)
                        {
                            x = rest / 3;
                            y = j;
                            z = i;
                            found = true;
                            break;
                        }
                    }
                }
            }

            if (x == y && y == z && x == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"{x} {y} {z}");

        }
    }
}




