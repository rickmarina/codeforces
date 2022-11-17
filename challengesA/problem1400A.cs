using System.Linq;
using System;

namespace codeforces.challengesA
{

    //A. Magical sticks
    public class problem1400A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var serie = Console.ReadLine();

                string final = "";
                for (int i = 0; i < n; i++)
                {
                    final += serie.Substring(i, n)[i];
                }

                Console.WriteLine(final);
            }

        }

    }

}