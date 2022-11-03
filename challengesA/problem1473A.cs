using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1473/A. Replacing Elements
    public class problem1473A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var nd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                var serie = Console.ReadLine().Split(" ").Select(int.Parse).OrderBy(x => x).ToArray();

                if (!serie.Any(x => x > nd[1]) || serie[0] + serie[1] <= nd[1])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                /*
                bool exists = false; 
                if (serie.Any(x=> x > nd[1])) {

                    for (int i=0; i<serie.Length& !exists;i++) { 
                        for (int j=i+1;j<serie.Length & !exists;j++) { 
                            if (serie[i] + serie[j] <= nd[1]) {
                                exists = true;
                            }
                        }
                    }

                    Console.WriteLine(exists ? "YES" : "NO");

                } else {
                    Console.WriteLine("YES");
                }
                */

            }

        }

    }

}