using System.Linq;
using System;

namespace codeforces.challengesA;

//1354/A. Alarm Clock
public class problem1354A
{

    public static void solution()
    {
        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            var dat = Console.ReadLine().Split(" ").Select(decimal.Parse).ToArray();
            decimal a = dat[0], b = dat[1], c = dat[2], d = dat[3];

            //a. the time Polycarp has to sleep for to feel refreshed
            //b. the time before the first alarm goes off
            //c. the time before every succeeding alarm goes off 
            //d. the time Polycarp spends to fall asleep.
            //10 3 6 4

            decimal time = 0;
            time += b;

            if (time < a)
            {
                if (d >= c)
                {
                    time = -1;
                }
                else
                {
                    decimal r = Math.Ceiling((a - time) / (c - d));
                    time += r * c;
                }
            }

            Console.WriteLine(time);
        }
    }
}

