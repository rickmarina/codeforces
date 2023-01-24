using System.Linq;
using System;

namespace codeforces.challengesC;

//1462/C. Unique Number
public class problem1462C
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {

            var x = int.Parse(Console.ReadLine());
            if (x > 45)
            {
                Console.WriteLine("-1");
            }
            else if (x < 10)
            {
                Console.WriteLine(x);
            }
            else
            {
                string num = "";
                int r = 9;
                while (r >= 1 && x > 0)
                {
                    if (x >= r)
                    {
                        x -= r;
                        num = num + r;
                    }
                    r--;
                }
                if (x > r)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(string.Join("", num.Reverse()));
                }
            }
        }
    }
}

