using System.Linq;
using System;

namespace codeforces.challengesA;

//205/A. Little Elephant and Rozdil
public class problem205A
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine()); //# cities
        var distances = Console.ReadLine().Split(" ").Select(long.Parse).ToList();
        var o = distances.OrderBy(x => x).ToList();

        if (n == 1)
            Console.WriteLine("1");
        else if (o[0] == o[1])
            Console.WriteLine("Still Rozdil");
        else
        {
            var idx = distances.FindIndex(0, x => x == o[0]) + 1;
            Console.WriteLine(idx);
        }
    }
}




