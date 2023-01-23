using System.Linq;
using System;

namespace codeforces.challengesB;

//1337/B. Kana and Dragon Quest game
public class problem1337B
{

    public static void solution()
    {
        // h/2 + 10 = h - 10 
        // h = 40 
        // if h <= 20 -> hit points incremented if VA

        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x = input[0], n = input[1], m = input[2]; //dragon hit points, max void absortions, max lighting strikes

            //first execute VA then lighting strikes and see hit points 
            for (int i = 0; i < n; i++)
            {
                if (x > 20)
                    x = (x / 2) + 10;
                else
                    break;
            }
            x -= 10 * m;

            Console.WriteLine(x > 0 ? "NO" : "YES");


        }
    }
}

