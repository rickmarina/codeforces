using System.Linq;
using System;

namespace codeforces.challengesA;

//1343/A. Candies
public class problem1343A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {

            int num = int.Parse(Console.ReadLine());

            int m = 1;
            for (int i = 1; i < 50; i++)
            {
                m = 2 * m + 1;
                if (num % m == 0)
                    break;
            }

            Console.WriteLine(num / m);


        }
    }
}

