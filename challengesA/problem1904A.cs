using System.Linq;
using System;

namespace codeforces.challengesA;

//A. Forked!
public class Problem1904A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var knight = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var king = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queen = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var offsets = new List<(int, int)>() {
            {(knight[0], knight[1])},
            {(knight[0], -knight[1])},
            {(-knight[0], knight[1])},
            {(-knight[0], -knight[1])},
            {(knight[1], knight[0])},
            {(knight[1], -knight[0])},
            {(-knight[1], knight[0])},
            {(-knight[1], -knight[0])}
        };

            var fromKing = offsets.Select(x => (king[0] + x.Item1, king[1] + x.Item2));
            var fromQueen = offsets.Select(x => (queen[0] + x.Item1, queen[1] + x.Item2));
            var intersect = fromKing.Intersect(fromQueen);

            //System.Console.WriteLine(string.Join(",", intersect));

            System.Console.WriteLine(intersect.Count());
        }
    }
}


