using System;
using System.Diagnostics;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input coins until command "Start":
            //  Valid coins are:
            //	0.1, 0.2, 0.5, 1, and 2
            //  If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
            string input = Console.ReadLine();
            double coinsSum = 0;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    input = Console.ReadLine();
                    continue;
                }

                coinsSum += coins;
                input = Console.ReadLine();
            }

            //2.Receiving products until command "End":
            //  "Nuts" with a price of 2.0
            //	"Water" with a price of 0.7
            //	"Crisps" with a price of 1.5
            //	"Soda" with a price of 0.8
            //	"Coke" with a price of 1.0
            //  If the customer tries to purchase a not existing product print "Invalid product".
            string products = Console.ReadLine();
            double productPrize = 0;
            bool isValid = true;
            while (products != "End")
            {
                switch (products)
                {
                    case "Nuts":
                        productPrize = 2;
                        break;

                    case "Water":
                        productPrize = 0.7;
                        break;

                    case "Crisps":
                        productPrize = 1.5;
                        break;

                    case "Soda":
                        productPrize = 0.8;
                        break;

                    case "Coke":
                        productPrize = 1;
                        break;

                        default:
                        Console.WriteLine("Invalid product");
                        isValid = false;
                        break;
                }

                if (!isValid)
                {
                    products = Console.ReadLine();
                    continue;
                }
                //3.When a customer has enough money to buy the selected product, print "Purchased {product name}",
                //  otherwise print "Sorry, not enough money", and continue to the next line.
                if (coinsSum >= productPrize)
                {
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    coinsSum -= productPrize;
                    products = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    products = Console.ReadLine();
                    continue;
                }
            }

            //4.When the "End" command is given print the reminding balance,
            //  formatted to the second decimal point:
            //  "Change: {money left}".
            Console.WriteLine($"Change: {coinsSum:F2}");
        }
    }
}
