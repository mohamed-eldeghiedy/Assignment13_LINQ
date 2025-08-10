
using System.Collections.Generic;
namespace Assignment13_LINQ
{
    internal class Program
    {
        static void Main()
        {

            //q1 : Element Operators

            #region p1: Get first Product out of Stock 

            //var product = ListGenerators.ProductList;

            //var FristOutOfStock = product.First(p => p.UnitsInStock == 0);

            //Console.WriteLine($"First Out of Stock Product: {FristOutOfStock.ProductName }");

            #endregion

            #region p2: . Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var product = ListGenerators.ProductList;
            var firstExpensiveProduct = product.FirstOrDefault(p => p.UnitPrice > 1000);
            if (firstExpensiveProduct != null)
            {
                Console.WriteLine($"Found: {firstExpensiveProduct.ProductName} - ${firstExpensiveProduct.UnitPrice}");
            }
            else
            {
                Console.WriteLine("No product found over $1000.");
            }


            #endregion
        }
    }
}
