using System.Linq;
using System;

namespace codeforces.challengesB;

//1436/B. Prime Square
public class problem1436B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            // n size of square 
            int n = int.Parse(Console.ReadLine());

            // search first prime for (n-1)*a + 1 
            int a = 1;
            while (!isPrime((n - 1) * a + 1) || isPrime(a))
            {
                a++;
            }
            // Console.WriteLine("prime: " + a);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1");
                    else
                        Console.Write(a);
                    if (j != n - 1)
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }

        }
    }
    static bool isPrime(int number)
    {

        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}




