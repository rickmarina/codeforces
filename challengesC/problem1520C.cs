using System.Linq;
using System;

namespace codeforces.challengesC;

//C. Not Adjacent Matrix
public class Problem1520C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
                System.Console.WriteLine("1");
            else if (n == 2)
                System.Console.WriteLine("-1");
            else if (n == 3)
            {
                System.Console.WriteLine($"2 9 7\n4 6 3\n1 8 5");
            }
            else
            {
                int k = 1;
                int l;
                if (n % 2 != 0)
                {
                    l = (n / 2 + 1) * n + 1;
                }
                else
                {
                    l = (n * n) / 2 + 1;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j % 2 == 0)
                            System.Console.Write($"{k++} ");
                        else
                            System.Console.Write($"{l++} ");
                    }
                    System.Console.WriteLine("");
                }
            }
        }
    }
}


