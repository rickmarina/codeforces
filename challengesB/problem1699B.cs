using System.Linq;
using System;

namespace codeforces.challengesB;

//1699/B. Almost Ternary Matrix
public class problem1699B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = dat[0], m = dat[1];

            string cad = "";
            for (int i = 0; i <= m; i++)
            {
                if ((i & 1) == 1)
                    cad += "00";
                else
                    cad += "11";
            }

            string cad1 = cad.Substring(1, m);
            string cad2 = cad.Substring(3, m);

            //Console.WriteLine(cad1);
            //Console.WriteLine(cad2);

            for (int j = 0; j < n / 2; j++)
            {
                if ((j & 1) == 1)
                {
                    Console.WriteLine(string.Join(" ", cad2.Select(x => x.ToString())));
                    Console.WriteLine(string.Join(" ", cad1.Select(x => x.ToString())));

                }
                else
                {
                    Console.WriteLine(string.Join(" ", cad1.Select(x => x.ToString())));
                    Console.WriteLine(string.Join(" ", cad2.Select(x => x.ToString())));
                }
            }
        }
    }
}


