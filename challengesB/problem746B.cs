using System.Linq;
using System;

namespace codeforces.challengesB;

//746/B. Decoding
public class problem746B
{

    public static void solution()
    {
        int n = int.Parse(Console.ReadLine());

        var encoded = Console.ReadLine();
        var decoded = string.Empty;

        for (int i = 0; i < n; i++)
        {
            if (n % 2 != 0)
            {
                if (i % 2 == 0)
                    decoded = decoded + encoded[i];
                else
                    decoded = encoded[i] + decoded;
            }
            else
            {
                if (i % 2 == 0)
                    decoded = encoded[i] + decoded;
                else
                    decoded = decoded + encoded[i];
            }
        }

        Console.WriteLine(decoded);
    }
}

