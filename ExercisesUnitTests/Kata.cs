using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesUnitTests
{
    public class Kata
    {
        public static string Battle(string x, string y)
        {
            var value = 0;
            for ( int i = 0; i < x.Length; i++ )
            {
                if(x[i] == 'A') value++;
                else if(x[i] == 'B') value += 2;
                else if(x[i] == 'C') value += 3;
                else if(x[i] == 'D') value += 4;
                else if(x[i] == 'E') value += 5;
                else if(x[i] == 'F') value += 6;
                else if(x[i] == 'G') value += 7;
                else if(x[i] == 'H') value += 8;
                else if(x[i] == 'I') value += 9;
                else if(x[i] == 'J') value += 10;
                else if(x[i] == 'K') value += 11;
                else if(x[i] == 'L') value += 12;
                else if(x[i] == 'M') value += 13;
                else if(x[i] == 'N') value += 14;
                else if(x[i] == 'O') value += 15;
                else if(x[i] == 'P') value += 16;
                else if(x[i] == 'Q') value += 17;
                else if(x[i] == 'R') value += 18;
                else if(x[i] == 'S') value += 19;
                else if(x[i] == 'T') value += 20;
                else if(x[i] == 'U') value += 21;
                else if(x[i] == 'V') value += 22;
                else if(x[i] == 'W') value += 23;
                else if(x[i] == 'X') value += 24;
                else if(x[i] == 'Y') value += 25;
                else if(x[i] == 'Z') value += 26;
            }
            var stringValue = Convert.ToString(value);
            return stringValue;
        }
    }
}
