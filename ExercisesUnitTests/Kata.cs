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
            var value2 = 0;

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

            for (int j = 0; j < y.Length; j++)
            {
                if (y[j] == 'A') value2++;
                else if (y[j] == 'B') value2 += 2;
                else if (y[j] == 'C') value2 += 3;
                else if (y[j] == 'D') value2 += 4;
                else if (y[j] == 'E') value2 += 5;
                else if (y[j] == 'F') value2 += 6;
                else if (y[j] == 'G') value2 += 7;
                else if (y[j] == 'H') value2 += 8;
                else if (y[j] == 'I') value2 += 9;
                else if (y[j] == 'J') value2 += 10;
                else if (y[j] == 'K') value2 += 11;
                else if (y[j] == 'L') value2 += 12;
                else if (y[j] == 'M') value2 += 13;
                else if (y[j] == 'N') value2 += 14;
                else if (y[j] == 'O') value2 += 15;
                else if (y[j] == 'P') value2 += 16;
                else if (y[j] == 'Q') value2 += 17;
                else if (y[j] == 'R') value2 += 18;
                else if (y[j] == 'S') value2 += 19;
                else if (y[j] == 'T') value2 += 20;
                else if (y[j] == 'U') value2 += 21;
                else if (y[j] == 'V') value2 += 22;
                else if (y[j] == 'W') value2 += 23;
                else if (y[j] == 'X') value2 += 24;
                else if (y[j] == 'Y') value2 += 25;
                else if (y[j] == 'Z') value2 += 26;
            }

            if (value > value2) 
                return x;
            else if (value < value2)
                return y;
            else
                return "TIE";
        }
    }
}
