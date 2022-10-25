using System.Linq;
using System;

namespace codeforces.challengesA
{

    //1607/A. Linear Keyboard
    public class problem1607A
    {

        public static void solution()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string keyboard = Console.ReadLine();
                string word = Console.ReadLine();

                int p = keyboard.IndexOf(word[0]);
                int time = 0;

                if (word.Length > 1)
                {
                    foreach (var c in word[1..])
                    {
                        int i = keyboard.IndexOf(c);
                        time += Math.Abs(p - i);
                        p = i;
                    }
                }

                Console.WriteLine(time);


            }

        }

    }