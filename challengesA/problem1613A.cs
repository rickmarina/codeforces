using System.Linq;
using System;

namespace codeforces.challengesA;

//1613/A. Long Comparison
public class problem1613A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        int count = 0;
        while (tc-- > 0)
        {
            count++;


            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x1 = dat[0], p1 = dat[1];

            var dat2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x2 = dat2[0], p2 = dat2[1];

            // if (count == 803) 
            //     Console.WriteLine($"x1:{x1}p1:{p1}x2:{x2}p2:{p2}");

            int sizeNum1 = x1.ToString().Length + p1;
            int sizeNum2 = x2.ToString().Length + p2;

            if (sizeNum1 == sizeNum2)
            {
                int max = Math.Max(x1.ToString().Length, x2.ToString().Length);

                int n1 = int.Parse(x1.ToString().PadRight(max, '0'));
                int n2 = int.Parse(x2.ToString().PadRight(max, '0'));

                Compare(n1, n2);
            }
            else
            {
                Compare(sizeNum1, sizeNum2);
            }

        }
    }
    static void Compare(int n1, int n2)
    {
        if (n1 == n2)
            Console.WriteLine("=");
        else if (n1 > n2)
            Console.WriteLine(">");
        else
            Console.WriteLine("<");
    }
}

