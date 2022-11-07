using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1567/A. Domino Disaster
    public class problem1567A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {

                int w = int.Parse(Console.ReadLine());

                string row = Console.ReadLine();

                foreach (var c in row)
                {
                    if (c == 'L' || c == 'R')
                        Console.Write(c.ToString());
                    else if (c == 'U')
                        Console.Write("D");
                    else if (c == 'D')
                        Console.Write("U");
                }

                Console.WriteLine();

            }

        }

    }

}