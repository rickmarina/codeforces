using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1754/B. Kevin and Permutation
    public class problem1754B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int i = n / 2;
                int j = n;
                if (n % 2 == 1) i++;

                while (i > 0)
                {
                    Console.Write($"{i} ");
                    i--;
                    if (i > 0)
                    {
                        Console.Write($"{j} ");
                        j--;
                    }
                }

                if (n % 2 == 0) Console.Write($"{j} ");
                Console.Write(Environment.NewLine);


            }


        }

    }

}