using System.Linq;
using System;

namespace codeforces.challengesA;

//1517/A. Sum of 2050
public class problem1517A
{
    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            long num = long.Parse(Console.ReadLine());
            int total = 0;
            while (num >= 2050)
            {
                total++;
                int add = Math.Max(0, num.ToString().Length - 4);
                long rest = long.Parse("2050" + new String('0', add));
                if (rest > num)
                {
                    rest = long.Parse("2050" + new String('0', add - 1));
                }
                num -= rest;
                //Console.WriteLine("restamos: "+rest.ToString()+" = "+num.ToString());
            }

            Console.WriteLine(num > 0 ? -1 : total);
        }
    }
}

