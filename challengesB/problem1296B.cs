using System.Linq;
using System;

namespace codeforces.challengesB;

//1296/B. Food Buying
public class problem1296B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int total = 0;
            int burles = int.Parse(Console.ReadLine());

            total = burles;

            while (burles >= 10)
            {
                total += (burles / 10);
                burles = (burles % 10) + (burles / 10);
            }

            Console.WriteLine(total);

        }
    }
}

