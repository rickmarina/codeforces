using System.Linq;
using System;

namespace codeforces.challengesA;

//1238/A. Prime Subtraction
public class problem1238A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            var nums = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            long x = nums[0], y = nums[1];

            long diff = x - y;

            //La resta de (dos números pares o dos impares) es un número par divisible por 2 n-veces (primo)
            // además cualquier número > 1 puede factorizarse con números primos por lo que podremos restar n veces el primo divisor 
            if ((diff % 2 == 0) || (diff > 1))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}

