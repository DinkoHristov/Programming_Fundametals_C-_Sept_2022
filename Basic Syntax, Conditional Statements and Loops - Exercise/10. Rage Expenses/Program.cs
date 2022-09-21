using System;
using System.Collections.Generic;
using System.Drawing;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            //  On the first input line - lost games count – integer in the range[0, 1000].
            //	On the second line – headset price -the floating - point number in the range[0, 1000]. 
            //	On the third line – mouse price -the floating - point number in the range[0, 1000]. 
            //	On the fourth line – keyboard price -the floating - point number in the range[0, 1000]. 
            //	On the fifth line – display price -the floating - point number in the range[0, 1000]. 
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrize = double.Parse(Console.ReadLine());
            double mousePrize = double.Parse(Console.ReadLine());
            double keyboardPrize = double.Parse(Console.ReadLine());
            double displayPrize = double.Parse(Console.ReadLine());

            //2.Every second lost game, Petar trashes his headset.
            //  Every third lost game, Petar trashes his mouse.
            //  When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //  Every second time, when he trashes his keyboard, he also trashes his display.
            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = lostGames / 12;

            double rageExpenses = trashedHeadset * headsetPrize + trashedMouse * mousePrize + trashedKeyboard * keyboardPrize +
                trashedDisplay * displayPrize;
            //3.As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."
            //	Allowed working time / memory: 100ms / 16MB.
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
