using System.Linq;
using System;

namespace codeforces.challengesC;

//1742/C. Stripes
public class problem1742C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var space = Console.ReadLine();

            string result = "B";
            for (int i = 0; i < 8; i++)
            {
                var line = Console.ReadLine();
                if (line.Count(x => x == 'R') == 8)
                {
                    result = "R";
                }
            }

            Console.WriteLine(result);


        }
    }
}

