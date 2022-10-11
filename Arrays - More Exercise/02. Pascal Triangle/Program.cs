using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (row == 1)
            {
                return;
            }


            int[] beforeArr = new int[] { 1, 1 };

            Console.WriteLine(string.Join(" ", beforeArr));
            if (row == 2)
            {
                return;
            }

            for (int i = 3; i <= row; i++)
            {
                int[] nextArr = new int[beforeArr.Length + 1];

                for (int j = 1; j < nextArr.Length - 1; j++)
                {
                    nextArr[0] = 1;
                    nextArr[nextArr.Length - 1] = 1;

                    nextArr[j] = beforeArr[j - 1] + beforeArr[j];
                }
                Console.WriteLine(string.Join(" ", nextArr));
                beforeArr = nextArr;
            }
        }
    }
}
