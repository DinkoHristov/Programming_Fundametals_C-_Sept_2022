using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> products = new Dictionary<string, List<decimal>>();

            string product = string.Empty;
            while ((product = Console.ReadLine()) != "buy")
            {
                List<decimal> productList = new List<decimal>();

                string[] productInfo = product.Split();
                string productName = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);
                decimal quantity = decimal.Parse(productInfo[2]);

                if (!products.ContainsKey(productName))
                {
                    productList.Add(productPrice);
                    productList.Add(quantity);

                    products.Add(productName, productList);
                }
                else
                {
                    for(int i = 0; i < products[productName].Count; i++)
                    {
                        if (i == 0)
                        {
                            decimal oldPrize = products[productName][i];
                            if (oldPrize != productPrice)
                            {
                                products[productName].RemoveAt(i);
                                products[productName].Insert(0, productPrice);
                            }
                        }
                        else if (i == 1)
                        {
                            decimal oldQuantity = products[productName][i];
                            quantity += oldQuantity;
                            products[productName].RemoveAt(i);
                            products[productName].Add(quantity);
                        }
                    }
                }
            }

            foreach(var currentProduct in products)
            {
                Console.WriteLine($"{currentProduct.Key} -> " +
                    $"{currentProduct.Value[0] * currentProduct.Value[1]}");
            }
        }
    }
}
