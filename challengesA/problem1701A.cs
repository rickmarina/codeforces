using System.Linq;
using System;

namespace codeforces.challengesA;

//1701/A. Grass Field
public class problem1701A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var l1 = Console.ReadLine();
            var l2 = Console.ReadLine();

            var r = l1.Concat(l2).Count(x => x == '1');

            int result = r switch
            {
                4 => 2,
                3 => 1,
                2 => 1,
                1 => 1,
                _ => 0

            };

            Console.WriteLine(result);
        }
    }
}

