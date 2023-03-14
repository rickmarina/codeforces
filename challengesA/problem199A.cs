using System.Linq;
using System;

namespace codeforces.challengesA;

//199/A. Hexadecimal's theorem
public class problem199A
{

    public static void solution()
    {
        //N is a Fibonacci number if and only if ( 5*N2 + 4 ) or ( 5*N2 – 4 ) is a perfect square! 

        //represent number fibonacci n as the sum of any 3 fibo numbers (not necessary different)
        // the hack is using the 0 as third number 
        // and search the previous two fibonacci numbers from n 

        long n = long.Parse(Console.ReadLine());
        long a = 0, b = 0, c = 0;

        if (n > 0)
        {
            a = 0;
            b = 1;
            while (a + b != n)
            {
                long aux = a;
                a = b;
                b = aux + b;
            }
        }


        Console.WriteLine($"{a} {b} {c}");
    }

    static bool isPerfectSquare(double n)
    {
        return Math.Sqrt(n) % 1 == 0;
    }

    static bool isInFiboSerie(long n)
    {
        return isPerfectSquare((5 * n * n) + 4) || isPerfectSquare((5 * n * n) - 4);
    }
}

