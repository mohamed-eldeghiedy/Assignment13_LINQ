
using System.Collections.Generic;
namespace Assignment13_LINQ
{
    internal class Program
    {
        static void Main()
        {

            //q1 : Element Operators

            #region p1: Get first Product out of Stock 

            var product = ListGenerators.ProductList;

            var FristOutOfStock = product.First(p => p.UnitsInStock == 0);

            Console.WriteLine($"First Out of Stock Product: {FristOutOfStock.ProductName }");

            #endregion
        }
    }
}
