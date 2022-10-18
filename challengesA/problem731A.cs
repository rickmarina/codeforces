using System.Linq;
using System; 

namespace codeforces.challengesA {

    //731/A. Night at the Museum
    public class problem731A {

        public static void solution() {
            int sum = 0; 
            string letters = "abcdefghijklmnopqrstuvwxyz"; 
            int pointer = 0; 
            string word = Console.ReadLine();

            foreach (char c in word) { 

                int pos = letters.IndexOf(c);
                int diff = Math.Abs(pos - pointer);
                int diffCW = 0;
                if (pos > pointer) 
                    diffCW = pointer + (letters.Length - pos);
                else 
                    diffCW = letters.Length - pointer + pos;

                pointer = pos;
                sum += Math.Min(diff, diffCW);
                
            }
            Console.WriteLine($"{sum}");
            
        }

    }

}