using System;
using System.Collections.Generic;
using System.Drawing;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.The input consists of 3 lines.
            //  	On the first line, you will receive N – an integer.
            //  	On the second line, you will receive M – an integer.
            //  	On the third line, you will receive Y – an integer.
            //1.1.Constraints:
            //  	The integer N will be in the range[1, 2.000.000.000].
            //  	The integer M will be in the range[1, 1.000.000].
            //  	The integer Y will be in the range[0, 9].
            //  	Allowed time / memory: 16 MB / 100ms.
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            //2.Task:
            //1. Your task is to start subtracting M from N until N becomes less than M,
            //   i.e. the Pokemon does not have enough power to reach the next target. 
            //2. Every time you subtract M from N that means you’ve reached a target and poked it successfully.
            //   COUNT how many targets you’ve poked – you’ll need that count.
            //3. The PokeMon becomes gradually more exhausted.
            //   IF N becomes equal to EXACTLY 50 % of its original value, you must divide N by Y, if it is POSSIBLE.
            //   This DIVISION is between integers.
            //   If a division is not possible, you should NOT do it. Instead, you should continue subtracting.
            //4. After dividing, you should continue subtracting from N, until it becomes less than M.
            //   When N becomes less than M,
            //   you must take what has remained of N and the count of targets you’ve poked, and print them as output.
            //   Example: 505 is NOT EXACTLY 50 % from 1000, its 50.5 %.
            int count = 0;
            int startingN = n;
            while (n > 0)
            {
                if (n >= m)
                {
                    n -= m;
                    count++;
                    if (n == (startingN * 0.5) && y != 0)
                    {
                        n /= y;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }
            }

            //3.The output consists of 2 lines.
            //  	On the first line print what has remained of N, after subtracting from it.
            //  	On the second line print the count of targets, you’ve managed to poke
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
