using System.Linq;
using System;

namespace codeforces.challengesC
{

    //1692/C. Where's the Bishop?
    public class problem1692C
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                _ = Console.ReadLine();

                int row = 0, column = 0;
                bool search = false;
                bool found = false;
                for (int i = 0; i < 8; i++)
                {
                    var line = Console.ReadLine();

                    if (search && !found)
                    {
                        if (line.Where(x => x == '#').Count() == 1)
                        {
                            column = line.IndexOf('#');
                            row = i;
                            found = true;
                        }
                    }

                    if (line.Where(x => x == '#').Count() > 1)
                    {
                        search = true;
                    }
                }

                Console.WriteLine($"{row + 1} {column + 1}");
            }

        }

    }

}