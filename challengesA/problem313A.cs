using System.Linq;
using System;

namespace codeforces.challengesA;

//313/A. Ilya and Bank Account
public class problem313A
{

    public static void solution()
    {
        string bank = Console.ReadLine();

        int last = int.Parse(bank[bank.Length - 1].ToString());
        int plast = int.Parse(bank[bank.Length - 2].ToString());

        int result = int.Parse(bank);

        if (result < 0)
        {
            if (last > plast)
                result = int.Parse(bank[..^1]);
            else
                result = int.Parse(bank[..^2] + bank[^1]);
        }

        Console.WriteLine(result);
    }
}

