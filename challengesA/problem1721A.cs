using System.Linq;
using System;

namespace codeforces.challengesA;

//1721/A. Image
public class problem1721A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {

            var l1 = Console.ReadLine();
            var l2 = Console.ReadLine();

            var d = l1.Concat(l2).Distinct().Count();

            Console.WriteLine($"{d - 1}");
        }
    }
}

