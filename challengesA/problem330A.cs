using System.Linq;
using System;

namespace codeforces.challengesA;

//330/A. Cakeminator
public class problem330A
{

    public static void solution()
    {
        var dim = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[][] map = new int[dim[0]][];

        HashSet<int> rows = new();
        HashSet<int> cols = new();


        for (int y = 0; y < dim[0]; y++)
        {
            map[y] =
            Console.ReadLine().Select((val, x) =>
            {
                if (val == 'S')
                {
                    rows.Add(y);
                    cols.Add(x);
                    return -1;
                }
                else
                    return 1;
            }).ToArray();
        }

        int totalRows = dim[0] - rows.Count();
        int totalCols = dim[1] - cols.Count();

        int total = (totalRows * dim[1]) + (totalCols * (dim[0] - totalRows));

        Console.WriteLine(total);
    }
}

