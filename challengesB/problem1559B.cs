using System.Linq;
using System;

namespace codeforces.challengesB;

//1559/B. Mocha and Red and Blue
public class problem1559B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            string cad = Console.ReadLine();
            var input = cad.ToArray();


            int lastR = cad.LastIndexOf('R');
            int lastB = cad.LastIndexOf('B');

            int max = Math.Max(lastR, lastB);

            for (int i = max - 1; i >= 0; i--)
            {
                if (input[i] == '?')
                {
                    if (input[i + 1] == 'R')
                        input[i] = 'B';
                    else
                        input[i] = 'R';
                }
            }

            for (int i = max + 1; i < input.Length; i++)
            {
                if (input[i] == '?')
                {
                    if (i == 0)
                        input[i] = 'B';
                    else if (input[i - 1] == 'R')
                        input[i] = 'B';
                    else
                        input[i] = 'R';
                }
            }

            Console.WriteLine(string.Join("", input));

        }
    }
}
