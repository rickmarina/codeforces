using System.Linq;
using System;

namespace codeforces.challengesA;

//B. Mislove Has Lost an Array
public class Problem1204B
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        (int n, int l, int r) = (input[0], input[1], input[2]);


        int minIdx = n - l + 1;
        var minserie = Enumerable.Range(0, n).Select((x, i) => i < minIdx ? 1 : Math.Pow(2, i - minIdx + 1));

        var maxserie = Enumerable.Range(0, n).Select((x, i) => Math.Pow(2, Math.Clamp(x, 0, r - 1)));


        System.Console.WriteLine(minserie.Sum());
        System.Console.WriteLine(maxserie.Sum());

        // System.Console.WriteLine(string.Join(',', minserie));
        // System.Console.WriteLine(string.Join(',', maxserie));
    }
}


