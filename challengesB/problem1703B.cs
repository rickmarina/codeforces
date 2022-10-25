using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1703/B. ICPC Balloons
    public class problem1703B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                int n = int.Parse(Console.ReadLine());

                var problems = Console.ReadLine();

                HashSet<char> solved = new HashSet<char>();
                int balloons = 0;
                foreach (char p in problems)
                {
                    if (!solved.Contains(p))
                    {
                        solved.Add(p);
                        balloons += 2;
                    }
                    else
                    {
                        balloons++;
                    }
                }

                Console.WriteLine($"{balloons}");
            }

        }

    }

}