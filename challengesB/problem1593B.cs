using System.Linq;
using System;

namespace codeforces.challengesB;

//1593/B. Make it Divisible by 25
public class problem1593B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            string num = Console.ReadLine();

            int total1 = Calculate(num, '0', '0', '5');
            int total2 = Calculate(num, '5', '2', '7');

            Console.WriteLine(Math.Min(total1, total2));

        }
    }

    static int Calculate(string num, char prim, char sec1, char sec2)
    {
        int total = 0;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (num[i] != prim)
                total++;
            else
            {
                int p1 = num.Substring(0, i).LastIndexOf(sec1);
                int p2 = num.Substring(0, i).LastIndexOf(sec2);
                //Console.WriteLine($"{num.Substring(0, i)} {p1} {p2} {i}");

                total += i - (Math.Max(p1, p2) + 1);
                break;
            }
        }
        return total;
    }
}

