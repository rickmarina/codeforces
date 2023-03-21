using System.Linq;
using System;

namespace codeforces.challengesB;

//1283/B. Candies Division
public class problem1283B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var data = Console.ReadLine().Split(" ").Select(long.Parse).ToList();

            //n candies 
            //k kids
            long n = data[0], k = data[1];
            long resto = n % k;
            long total = (n - resto) + Math.Min(resto, k / 2);

            Console.WriteLine(total);
        }
    }
}

