using System.Linq;
using System;

namespace codeforces.challengesA;

//501/A. Contest
public class problem501A
{

    public static void solution()
    {
        var dat = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        int a = dat[0], b = dat[1]; //points 
        int c = dat[2], d = dat[3]; //time 

        int tMisha = Math.Max(3 * a / 10, a - (a / 250) * c);
        int tVasya = Math.Max(3 * b / 10, b - (b / 250) * d);

        if (tMisha == tVasya)
            Console.WriteLine("Tie");
        else if (tMisha > tVasya)
            Console.WriteLine("Misha");
        else
            Console.WriteLine("Vasya");
    }
}


