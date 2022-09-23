using System.Linq;
using System;

namespace codeforces.challengesA
{

    //80/A. Panoramix's Prediction
    public class problem80A
    {

        public static void solution()
        {
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = nums[0];
            int m = nums[1];

            bool primefound = false;

            while (!primefound)
            {
                n++;
                primefound = isPrime(n);
            }

            Console.WriteLine(n == m ? "YES" : "NO");

        }

        static bool isPrime(int number)
        {

            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

}