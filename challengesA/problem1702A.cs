using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1702/A. Round Down the Price
    public class problem1702A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                double price = double.Parse(Console.ReadLine());

                double pow = Math.Pow(10, price.ToString().Length - 1);

                double res = price - pow;

                Console.WriteLine(res);

            }

        }

    }

}