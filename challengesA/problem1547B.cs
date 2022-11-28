using System.Linq;
using System;

namespace codeforces.challengesB
{

    //1547/B. Alphabetical Strings
    public class problem1547B
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                var cad = Console.ReadLine();

                int p0 = cad.IndexOf('a');
                //int p1 = p0-1; 
                int p1 = Math.Max(p0 - 1, 0);
                //int p2 = p0+1; 
                int p2 = Math.Min(p0 + 1, cad.Length - 1);

                if (p0 == -1)
                {
                    Console.WriteLine("NO");
                }
                else
                {

                    int total = 0;
                    while (total < cad.Length)
                    {
                        int r1 = (int)cad[p1] - (int)cad[p0];
                        int r2 = (int)cad[p2] - (int)cad[p0];

                        //Console.WriteLine($"letter: {cad[p0]} r1: {r1} r2: {r2} p1:{p1} p2:{p2}");

                        if (r1 == 1)
                        {
                            p0 = p1;
                            p1--;
                            p1 = Math.Max(p1, 0);
                            total++;
                        }
                        else if (r2 == 1)
                        {
                            p0 = p2;
                            p2++;
                            p2 = Math.Min(p2, cad.Length - 1);
                            total++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //Console.WriteLine($"total {total} p0: {p0} p1:{p1} p2:{p2}");
                    if (total + 1 >= cad.Length)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");

                }

            }

        }

    }

}