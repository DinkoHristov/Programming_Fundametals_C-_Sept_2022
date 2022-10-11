using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split(' ');
                string commandType = commandArgs[0];

                if (commandType == "exchange")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index < 0 || index >= originalArray.Length)
                    {
                        //Invalid index
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    originalArray = ExchangeArray(originalArray, index);
                }
                else if (commandType == "max")
                {
                    string evenOrOdd = commandArgs[1];
                    if (evenOrOdd == "even")
                    {
                        int evenMaxIndex = EvenOrOddMaxIndex(originalArray, evenOrOdd);
                        if (evenMaxIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine(evenMaxIndex);
                    }
                    else if (evenOrOdd == "odd")
                    {
                        int oddMaxIndex = EvenOrOddMaxIndex(originalArray, evenOrOdd);
                        if (oddMaxIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine(oddMaxIndex);
                    }
                    else
                    {
                        //Cannot be found. (Invalid)
                        Console.WriteLine("No matches");
                        command = Console.ReadLine();
                        continue;
                    }


                }
                else if (commandType == "min")
                {
                    string evenOrOdd = commandArgs[1];
                    if (evenOrOdd == "even")
                    {
                        int evenMinIndex = EvenOrOddMinIndex(originalArray, evenOrOdd);
                        if (evenMinIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine(evenMinIndex);
                    }
                    else if (evenOrOdd == "odd")
                    {
                        int oddMinIndex = EvenOrOddMinIndex(originalArray, evenOrOdd);
                        if (oddMinIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine(oddMinIndex);
                    }
                    else
                    {
                        //Cannot be found. (Invalid)
                        Console.WriteLine("No matches");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (commandType == "first")
                {
                    int count = int.Parse(commandArgs[1]);
                    string evenOrOdd = commandArgs[2];
                    int[] firstArrayElements;

                    if (count > originalArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (evenOrOdd == "even")
                    {
                        firstArrayElements = FirstEvenOrOddElements(originalArray, count, evenOrOdd);
                        PrintArray(firstArrayElements);
                    }
                    else if (evenOrOdd == "odd")
                    {
                        firstArrayElements = FirstEvenOrOddElements(originalArray, count, evenOrOdd);
                        PrintArray(firstArrayElements);
                    }

                }
                else if (commandType == "last")
                {
                    int count = int.Parse(commandArgs[1]);
                    string evenOrOdd = commandArgs[2];
                    int[] lastArrayEelements = new int[count];

                    if (count > originalArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (evenOrOdd == "even")
                    {
                        lastArrayEelements = LastEvenOrOddElements(originalArray, count, evenOrOdd);
                        PrintArray(lastArrayEelements);
                    }
                    else if (evenOrOdd == "odd")
                    {
                        lastArrayEelements = LastEvenOrOddElements(originalArray, count, evenOrOdd);
                        PrintArray(lastArrayEelements);
                    }

                }

                command = Console.ReadLine();
            }

            PrintArray(originalArray);
        }

        //Returns the modified version of the original array.
        static int[] ExchangeArray(int[] originalArray, int index)
        {
            int[] modifiedArray = new int[originalArray.Length];
            int modifiedIndexCount = 0;

            for (int i = index + 1; i < originalArray.Length; i++)
            {
                modifiedArray[modifiedIndexCount] = originalArray[i];
                modifiedIndexCount++;
            }

            for (int i = 0; i <= index; i++)
            {
                modifiedArray[modifiedIndexCount] = originalArray[i];
                modifiedIndexCount++;
            }

            return modifiedArray;
        }

        //Returns the max index of even or odd element
        static int EvenOrOddMaxIndex(int[] originalArray, string evenOrOdd)
        {
            int evenMax = int.MinValue;
            int oddMax = int.MinValue;
            int index = -1;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    if (originalArray[i] % 2 == 0)
                    {
                        int evenNumber = originalArray[i];
                        if (evenNumber >= evenMax)
                        {
                            evenMax = evenNumber;
                            index = i;
                        }
                    }
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    if (originalArray[i] % 2 != 0)
                    {
                        int oddNumber = originalArray[i];
                        if (oddNumber >= oddMax)
                        {
                            oddMax = oddNumber;
                            index = i;
                        }
                    }
                }
            }

            return index;
        }

        //Returns min index
        static int EvenOrOddMinIndex(int[] originalArray, string evenOrOdd)
        {
            int evenMin = int.MaxValue;
            int oddMin = int.MaxValue;
            int index = -1;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    if (originalArray[i] % 2 == 0)
                    {
                        int evenNumber = originalArray[i];
                        if (evenNumber <= evenMin)
                        {
                            evenMin = evenNumber;
                            index = i;
                        }
                    }
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    if (originalArray[i] % 2 != 0)
                    {
                        int oddNumber = originalArray[i];
                        if (oddNumber <= oddMin)
                        {
                            oddMin = oddNumber;
                            index = i;
                        }
                    }
                }
            }

            return index;
        }

        //Returns first even/odd {count} elements in the array
        static int[] FirstEvenOrOddElements(int[] originalArray, int count, string evenOrOdd)
        {
            int[] countArray = new int[count];
            int countArrayindex = 0;
            bool isCountArrayEmpty = true;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    int currentNumber = originalArray[i];
                    if (currentNumber % 2 == 0)
                    {
                        if (count > 0)
                        {
                            countArray[countArrayindex] = currentNumber;
                            countArrayindex++;
                            count--;
                            isCountArrayEmpty = false;
                        }
                    }
                }

                if (isCountArrayEmpty)
                {
                    countArray = new int[] { };
                }

                countArray = ResizedArray(countArray, countArrayindex);
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    int currentNumber = originalArray[i];
                    if (currentNumber % 2 != 0)
                    {
                        if (count > 0)
                        {
                            countArray[countArrayindex] = currentNumber;
                            countArrayindex++;
                            count--;
                            isCountArrayEmpty = false;
                        }
                    }
                }

                if (isCountArrayEmpty)
                {
                    countArray = new int[] { };
                }

                countArray = ResizedArray(countArray, countArrayindex);
            }

            return countArray;
        }

        //Returns last even/odd {count} elements in the array
        static int[] LastEvenOrOddElements(int[] originalArray, int count, string evenOrOdd)
        {
            int[] countArray = new int[count];
            int countArrayindex = 0;
            bool isCountArrayEmpty = true;

            if (evenOrOdd == "even")
            {
                for (int i = originalArray.Length - 1; i >= 0; i--)
                {
                    int currentNumber = originalArray[i];
                    if (currentNumber % 2 == 0)
                    {
                        if (count > 0)
                        {
                            countArray[countArrayindex] = currentNumber;
                            countArrayindex++;
                            count--;
                            isCountArrayEmpty = false;
                        }
                    }
                }

                if (isCountArrayEmpty)
                {
                    countArray = new int[] { };
                }

                countArray = ResizedArray(countArray, countArrayindex);
                countArray = ReversedArray(countArray);
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = originalArray.Length - 1; i >= 0; i--)
                {
                    int currentNumber = originalArray[i];
                    if (currentNumber % 2 != 0)
                    {
                        if (count > 0)
                        {
                            countArray[countArrayindex] = currentNumber;
                            countArrayindex++;
                            count--;
                            isCountArrayEmpty = false;
                        }
                    }
                }

                if (isCountArrayEmpty)
                {
                    countArray = ResizedArray(countArray, countArrayindex);
                }

                countArray = ResizedArray(countArray, countArrayindex);
                countArray = ReversedArray(countArray);
            }
            return countArray;
        }

        static int[] ResizedArray(int[] originalArray, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArray[i];
            }

            return modifiedArray;
        }

        static int[] ReversedArray(int[] originalArray)
        {
            int[] reversedArray = new int[originalArray.Length];
            for (int i = originalArray.Length - 1; i >= 0; i--)
            {
                reversedArray[reversedArray.Length - i - 1] = originalArray[i];
            }

            return reversedArray;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
