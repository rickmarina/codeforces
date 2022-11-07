using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1633/A. Div. 7
    public class problem1633A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 7 == 0)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    int k = num % 7;
                    int x = 7 - k;
                    if (num % 10 >= 7)
                    {
                        Console.WriteLine($"{num - k}");
                    }
                    else if (num % 10 <= 3)
                    {
                        Console.WriteLine($"{num + x}");
                    }
                    else
                    {
                        int z = num % 10;
                        if (z >= k)
                        {
                            Console.WriteLine($"{num - k}");
                        }
                        else
                        {
                            Console.WriteLine($"{num + x}");
                        }
                    }
                }
            }

        }

    }

}