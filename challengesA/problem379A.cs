using System.Linq;
using System;

namespace codeforces.challengesA;

//A. New Year Candles
public class Problem379A
{

    public static void solution()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //a #candles 
        //b to make new candle
        (int a, int b) = (input[0], input[1]);

        //4 2
        //4 + 4/2 + 2/2 = 7

        int total = a;
        int candles = a;
        while (candles >= b)
        {
            int rest = candles % b;
            candles = candles / b;
            total += candles;
            candles += rest;


        }

        System.Console.WriteLine(total);
    }
}


