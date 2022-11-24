using System.Linq;
using System;

namespace codeforces.challengesA
{

    //119/A. Epic Game
    public class problem119A
    {

        public static void solution()
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int a = input[0], b = input[1], n = input[2];

            int turn = 0;
            while (n > 0)
            {
                int r = 0;
                if (turn == 0)
                    r = GCD(a, n);
                else
                    r = GCD(b, n);

                if (r <= n)
                {
                    turn = 1 - turn;
                }
                n -= r;


            }

            Console.WriteLine(1 - turn);

        }

        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

    }

}