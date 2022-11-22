using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1633/B. Minority
    public class problem1633B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var input = Console.ReadLine();

                int total1 = input.Where(x => x == '1').Count();
                int total0 = input.Where(x => x == '0').Count();

                if (total1 == total0)
                    Console.WriteLine(total1 - 1);
                else
                    Console.WriteLine(Math.Min(total1, total0));

            }

        }

    }

}