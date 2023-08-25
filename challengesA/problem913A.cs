using System.Linq;
using System;

namespace codeforces.challengesA;

//913/A. Modular Exponentiation
public class problem913A
{

    public static void solution()
    {
        double n = long.Parse(Console.ReadLine());
        double m = long.Parse(Console.ReadLine());

        double result = m % Math.Pow(2, n);

        Console.WriteLine($"{result}");
    }
}


