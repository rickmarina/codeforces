using System.Linq;
using System;

namespace codeforces.challengesB;

//B. String LCM
public class Problem1473B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int gcd = GCD(s.Length, t.Length);
            // System.Console.WriteLine($"GCD: {gcd} {string.Join("", Enumerable.Repeat(s, t.Length/gcd))} {string.Join("", Enumerable.Repeat(t, s.Length/gcd))}");

            string cad1 = string.Join("", Enumerable.Repeat(s, t.Length / gcd));
            string cad2 = string.Join("", Enumerable.Repeat(t, s.Length / gcd));

            if (cad1 == cad2)
            {
                System.Console.WriteLine(cad1);
            }
            else
            {
                System.Console.WriteLine("-1");
            }



        }

    }

    public static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }
}


