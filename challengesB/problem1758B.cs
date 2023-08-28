using System.Linq;
using System;

namespace codeforces.challengesB;

//1758/B. XOR = Average
public class problem1758B
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                //xor of the same number in a odd serie has as result the same number, average = xor all numbers
                var arr = Enumerable.Repeat(1, n);
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                //xor of 2 and 6 is 4, then if we repeat 4 in a even serie .. average = xor 2,6,4,4,4,4...
                var arr = new List<int>() { 2, 6 };
                Console.WriteLine(string.Join(" ", arr.Concat(Enumerable.Repeat(4, n - 2))));
            }
        }
    }
}


