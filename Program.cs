﻿
namespace codeforces;

//A. Filling Shapes
class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int ans = 0;
        if ((n & 1) != 1)
        {
            ans = 1 << (n / 2);
        }

        Console.WriteLine(ans);
    }

}

