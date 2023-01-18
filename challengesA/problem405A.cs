using System.Linq;
using System;

namespace codeforces.challengesA;

//405/A. Gravity Flip
public class problem405A
{

    public static void solution()
    {
        //Cubes after falling result as an ordered collection of the initial cubes
        int n = int.Parse(Console.ReadLine());

        var cubes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        var result = cubes.OrderBy(x => x);

        Console.WriteLine(string.Join(" ", result));
    }
}

