using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1388/A. Captain Flint and Crew Recruitment
    public class problem1388A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int p1 = 6, p2 = 10, p3 = 14, p4 = 15;

                int a = n - (p1 + p2 + p3);
                if (a == p1 || a == p2 || a == p3)
                {
                    a = n - (p1 + p2 + p4);
                    Console.WriteLine("YES");
                    Console.WriteLine($"{p1} {p2} {p4} {a}");
                }
                else
                {

                    if (a > 0)
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine($"{p1} {p2} {p3} {a}");
                    }
                    else
                    {
                        Console.WriteLine("NO");

                    }
                }

            }

        }

    }

}