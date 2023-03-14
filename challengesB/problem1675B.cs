using System.Linq;
using System;

namespace codeforces.challengesB;

//1675/B. Make It Increasing
public class problem1675B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        //int tc = 1;

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            //int n = 5;
            var serie = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            //var serie = "8 26 5 21 10".Split(" ").Select(long.Parse).ToArray();

            long total = 0;
            bool imposible = false;
            for (int i = n - 2; i >= 0 && !imposible; i--)
            {

                if (serie[i + 1] == 0)
                {
                    imposible = true;
                    total = -1;
                }



                else if (serie[i] >= serie[i + 1])
                {
                    long div = serie[i] / serie[i + 1];

                    // int exp = 0; 
                    // while (Math.Pow(2,exp) <= div) {
                    //     exp++;
                    // }

                    //2 ^x > div --> x > log(div)/log(2)
                    long exp = (long)(Math.Log(div) / Math.Log(2)) + 1;

                    total += exp;
                    serie[i] /= (long)Math.Pow(2, exp);
                }



            }

            Console.WriteLine(total);
        }
    }

}