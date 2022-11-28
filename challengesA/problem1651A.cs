using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1651/A. Captain Flint and Crew Recruitment
    public class problem1651A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                double teams = Math.Pow(2, n);

                Console.WriteLine(teams - 1);


            }

        }

    }

}