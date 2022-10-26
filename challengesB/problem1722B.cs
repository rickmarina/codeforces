using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1722/B. Colourblindness
    public class problem1722B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int rows = int.Parse(Console.ReadLine());

                string row1 = Console.ReadLine();
                string row2 = Console.ReadLine();

                row1 = row1.Replace("G", "*").Replace("B", "*");
                row2 = row2.Replace("G", "*").Replace("B", "*");

                if (row1.Equals(row2))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");


            }

        }

    }
}