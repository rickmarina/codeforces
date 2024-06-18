using System;
using System.Linq;

namespace codeforces;

//A. Make It Zero
class Program
{
    static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            int[] v = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (n % 2 == 0)
            {
                System.Console.WriteLine("2");
                System.Console.WriteLine($"1 {n}"); // First time xor all elements to obtain one number and set this number in the array
                System.Console.WriteLine($"1 {n}"); // xor the same number even times gives 0
            }
            else
            {
                System.Console.WriteLine("4");
                System.Console.WriteLine($"1 {n}"); // First time xor all elements to obtain x in all vector
                System.Console.WriteLine($"2 {n}"); // Xor even elements 2..n to get 0
                System.Console.WriteLine($"1 2"); // Xor 1 , 2, to get y in first two positions
                System.Console.WriteLine($"1 2"); // xor y and y to get zero 

            }
        }
    }


}
