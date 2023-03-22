using System.Linq;
using System;

namespace codeforces.challengesA;

//1606/A. AB Balance
public class problem1606A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            string cad = Console.ReadLine();
            var arr = cad.ToArray();

            if (arr[0] != arr[arr.Length - 1])
                arr[0] = arr[arr.Length - 1];

            Console.WriteLine(new String(arr));

        }
    }
}


