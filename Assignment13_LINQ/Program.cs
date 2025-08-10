
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

            //var product = ListGenerators.ProductList;
            //var firstExpensiveProduct = product.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (firstExpensiveProduct != null)
            //{
            //    Console.WriteLine($"Found: {firstExpensiveProduct.ProductName} - ${firstExpensiveProduct.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found over $1000.");
            //}


            #endregion

            #region p3: Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var SecondNumberGreaterThan5 = Arr
            //    .Where(n => n > 5)
            //    .Skip(1)
            //    .FirstOrDefault();
            //if (SecondNumberGreaterThan5 != 0)
            //{
            //    Console.WriteLine($"Second number greater than 5 is: {SecondNumberGreaterThan5}");
            //}
            //else
            //{
            //    Console.WriteLine("There is no second number greater than 5.");
            //}


            #endregion



            // Aggregate Operators

            #region p1:  Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine($"Number of odd numbers in the array: {oddCount}");

            #endregion

            #region p2: Return a list of customers and how many orders each has.

            ///*var customers = ListGenerators.CustomerList;

            //var customerOrderCounts = customers
            //    .Select(c => new
            //    {
            //        CustomerName = c.CustomerName,
            //        OrderCount = c.Orders.Count()
            //    })
            //    .ToList();

            //foreach(var item in customerOrderCounts )
            //{
            //    Console.WriteLine($"{item.CustomerName} has {item.OrderCount} orders.");
            //}*/


            #endregion

            #region p3: Return a list of categories and how many products each has

            //var categories = ListGenerators.ProductList;

            //var categoryProductCounts = categories
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductCount = g.Count()
            //    })
            //    .ToList();
            //foreach (var item in categoryProductCounts)
            //{
            //    Console.WriteLine($"{item.Category} has {item.ProductCount} products.");
            //}


            #endregion

            #region p4: Get the total of the numbers in an array.

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = arr.Sum();
            //Console.WriteLine($"Total of the numbers in the array: {total}");

            #endregion

            #region p5: Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            string[] words = File.ReadAllLines("dictionary_english.txt");
            int totalCharacters = words.Sum(word => word.Length);
            Console.WriteLine($"Total number of characters in dictionary_english.txt: {totalCharacters}");
            #endregion

        }
    }
}
