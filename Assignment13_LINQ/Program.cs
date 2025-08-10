
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


            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total number of characters in dictionary_english.txt: {totalCharacters}");
            #endregion

            #region p6:  Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int shortestLength = words.Min(word => word.Length);

            //Console.WriteLine($"Length of the shortest word: {shortestLength}");

            #endregion

            #region p7:Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int longestLength = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the longest word: {longestLength}");

            #endregion

            #region p8: Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //double averageLength = words.Average(word => word.Length);
            //Console.WriteLine($"Average length of the words: {averageLength}");

            #endregion

            #region p9:  Get the total units in stock for each product category.

            //var result = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    })
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} has a total of {item.TotalUnitsInStock} units in stock.");
            //}


            #endregion

            #region p10:Get the cheapest price among each category's products

            //var result = ListGenerators.ProductList;
            //var cheapestPrices = result
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    })
            //    .ToList();
            //foreach (var item in cheapestPrices)
            //{
            //    Console.WriteLine($"Cheapest price in {item.Category} category: ${item.CheapestPrice}");
            //}


            #endregion

            #region p11: Get the products with the cheapest price in each category (Use Let)

            //var cheapestProducts =
            //   from product in ListGenerators.ProductList
            //   group product by product.Category into categoryGroup
            //   let minPrice = categoryGroup.Min(p => p.UnitPrice)
            //   from p in categoryGroup
            //   where p.UnitPrice == minPrice
            //   select new
            //   {
            //       Category = categoryGroup.Key,
            //       ProductName = p.ProductName,
            //       UnitPrice = p.UnitPrice
            //   };
            //foreach (var item in cheapestProducts)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: ${item.UnitPrice}");
            //}


            #endregion

            #region p12: Get the most expensive price among each category's products.

            //var mostExpensivePrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MostExpensivePrice = g.Max(p => p.UnitPrice)
            //    })
            //    .ToList();
            //foreach (var item in mostExpensivePrices) 
            //{
            //    Console.WriteLine($"Most expensive price in {item.Category} category: ${item.MostExpensivePrice}");
            //}

            #endregion

            #region p13: Get the products with the most expensive price in each category.

            //var mostExpensiveProducts =
            //    from product in ListGenerators.ProductList
            //    group product by product.Category into categoryGroup
            //    let maxPrice = categoryGroup.Max(p => p.UnitPrice)
            //    from p in categoryGroup
            //    where p.UnitPrice == maxPrice
            //    select new
            //    {
            //        Category = categoryGroup.Key,
            //        ProductName = p.ProductName,
            //        UnitPrice = p.UnitPrice
            //    };
            //foreach (var item in mostExpensiveProducts)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: ${item.UnitPrice}");
            //}


            #endregion

            #region p14: Get the average price of each category's products.

            //var averagePrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    })
            //    .ToList();
            //foreach (var item in averagePrices)
            //{
            //    Console.WriteLine($"Average price in {item.Category} category: ${item.AveragePrice}");
            //}


            #endregion



            // Set Operators

            #region p1: Find the unique Category names from Product List

            //var uniqueCategories = ListGenerators.ProductList
            //    .Select(p => p.Category)
            //    .Distinct()
            //    .OrderBy(c => c); 

            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}



            #endregion

            #region p2:  Produce a Sequence containing the unique first letter from both product and customer names.

            //var productFirstLetters = ListGenerators.ProductList
            //    .Select(p => p.ProductName[0]);

            //var customerFirstLetters = ListGenerators.CustomerList
            //    .Select(c => c.CustomerName[0]);

            //var uniqueFirstLetters = productFirstLetters
            //    .Concat(customerFirstLetters)
            //    .Distinct()
            //    .OrderBy(c => c);
            //Console.WriteLine("Unique first letters from products and customers:");

            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region p3: Create one sequence that contains the common first letter from both product and customer names.

            //var productFirstLetters = ListGenerators.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Distinct();

            //var customerFirstLetters = ListGenerators.CustomerList
            //    .Select(c => c.CustomerName[0])
            //    .Distinct();

            //var commonFirstLetters = productFirstLetters
            //    .Intersect(customerFirstLetters)
            //    .OrderBy(c => c); 

            //Console.WriteLine("Common first letters from products and customers:");

            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region p4:  Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var productFirstLetters = ListGenerators.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Distinct();

            //var customerFirstLetters = ListGenerators.CustomerList
            //    .Select(c => c.CustomerName[0])
            //    .Distinct();

            //var uniqueProductLetters = productFirstLetters
            //    .Except(customerFirstLetters)
            //    .OrderBy(c => c);

            //Console.WriteLine("Product name first letters NOT in customer name first letters:");

            //foreach (var letter in uniqueProductLetters)
            //{
            //    Console.WriteLine(letter);
            //}


            #endregion

            #region p5: Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates


            //var productLastThree = ListGenerators.ProductList
            //    .Select(p => p.ProductName.Length >= 3
            //                 ? p.ProductName.Substring(p.ProductName.Length - 3)
            //                 : p.ProductName);

            //var customerLastThree = ListGenerators.CustomerList
            //    .Select(c => c.CustomerName.Length >= 3
            //                 ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            //                 : c.CustomerName);

            //var combinedLastThree = productLastThree.Concat(customerLastThree);

            //Console.WriteLine("Last three characters from all product and customer names:");

            //foreach (var str in combinedLastThree)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion



            //Partitioning Operators

            #region p1: Get the first 3 orders from customers in Washington

            //var ordersFromWashington = ListGenerators.CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3)
            //    .ToList();
            //Console.WriteLine("First 3 orders from customers in Washington:");
            //foreach (var order in ordersFromWashington)
            //{
            //    Console.WriteLine(order);
            //}


            #endregion

            #region p2:  Get all but the first 2 orders from customers in Washington.
            //var ordersFromWashington = ListGenerators.CustomerList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2)
            //    .ToList();
            //Console.WriteLine("All but the first 2 orders from customers in Washington:");
            //foreach (var order in ordersFromWashington)
            //{
            //    Console.WriteLine(order);
            //}


            #endregion

            #region p3:  Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers
            //    .TakeWhile((number, index) => number >= index)
            //    .ToList();
            //Console.WriteLine("Elements until a number is less than its position:");
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion

            #region p4: Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers
            //    .SkipWhile(number => number % 3 != 0)
            //    .ToList();
            //Console.WriteLine("Elements starting from the first divisible by 3:");
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}



            #endregion

            #region p5: Get the elements of the array starting from the first element less than its position.
            
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers
                .SkipWhile((number, index) => number >= index)
                .ToList();
            Console.WriteLine("Elements starting from the first less than its position:");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }



            #endregion


        }
    }
}
