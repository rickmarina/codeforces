using System.Linq;
using System;

namespace codeforces.challengesB {

    //Borze
    public class problem32B {

        public static void solution() {
            string borze = Console.ReadLine();
            string number = ""; 

            for (int i = 0; i < borze.Length; i++)
            {
                if (borze[i] == '.') 
                    number += "0";
                else if (borze[i+1] == '.') {
                    number += "1";
                    i++;
                    }
                else {
                    number += "2";
                    i++;
                    }
            }

            System.Console.WriteLine(number);
            
        }

    }

}