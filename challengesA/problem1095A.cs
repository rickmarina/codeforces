using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1095/A. Repeating Cipher
    public class problem1095A
    {

        public static void solution()
        {
            int n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            int j = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(input[i]);
                i += j;
                j++;
            }

            Console.WriteLine("");

        }

    }

}