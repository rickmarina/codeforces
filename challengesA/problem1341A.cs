using System.Linq;
using System;

namespace codeforces.challengesA;

//1341/A. Nastya and Rice
public class problem1341A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0], a = input[1], b = input[2], c = input[3], d = input[4];
            // n # grains 
            // one grain-> (a-b) to (a+b)
            // total -> (c-d) to (c+d)

            int g1 = (a - b) * n;
            int g2 = (a + b) * n;

            int total1 = (c - d);
            int total2 = (c + d);


            if ((g2 >= total1) && (g1 <= total2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}

