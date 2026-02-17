using System;
using System.Linq;
using NorthwindHomework.Models;

namespace ConsoleApp23
{


    class Program
    {
        static void Main()
        {
            using var context = new NorthwindContext();

            // 1. Всички клиенти
            Console.WriteLine("1. Всички клиенти:");
            var customers = context.Customers
                .Select(c => new { c.CustomerId, c.CompanyName, c.Country });

            foreach (var c in customers)
                Console.WriteLine($"{c.CustomerId} | {c.CompanyName} | {c.Country}");

            // 2. Сортирани клиенти
            Console.WriteLine("\n2. Сортирани клиенти:");
            var sortedCustomers = context.Customers
                .OrderBy(c => c.Country)
                .ThenBy(c => c.CompanyName)
                .Select(c => new { c.CompanyName, c.Country });

            foreach (var c in sortedCustomers)
                Console.WriteLine($"{c.CompanyName} | {c.Country}");

            // 3. Служители
            Console.WriteLine("\n3. Служители:");
            var employees = context.Employees
                .Select(e => new { e.FirstName, e.LastName, e.Title });

            foreach (var e in employees)
                Console.WriteLine($"{e.FirstName} {e.LastName} | {e.Title}");

            // 4. Продукти от категория Beverages
            Console.WriteLine("\n4. Продукти от Beverages:");
            var beverages = context.Products
                .Where(p => p.Category.CategoryName == "Beverages")
                .Select(p => new { p.ProductName, p.Category.CategoryName });

            foreach (var p in beverages)
                Console.WriteLine($"{p.ProductName} | {p.CategoryName}");

            // 5. Продукти с цена > 30
            Console.WriteLine("\n5. Продукти с цена > 30:");
            var expensiveProducts = context.Products
                .Where(p => p.UnitPrice > 30)
                .OrderByDescending(p => p.UnitPrice)
                .Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var p in expensiveProducts)
                Console.WriteLine($"{p.ProductName} | {p.UnitPrice}");

            // 6. Поръчки от 1997
            Console.WriteLine("\n6. Поръчки от 1997:");
            var orders1997 = context.Orders
                .Where(o => o.OrderDate.Value.Year == 1997)
                .Select(o => new { o.OrderId, o.CustomerId, o.OrderDate });

            foreach (var o in orders1997)
                Console.WriteLine($"{o.OrderId} | {o.CustomerId} | {o.OrderDate}");

            // 7. Топ 10 клиенти по брой поръчки
            Console.WriteLine("\n7. Топ 10 клиенти по брой поръчки:");
            var topCustomers = context.Orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, OrdersCount = g.Count() })
                .OrderByDescending(x => x.OrdersCount)
                .Take(10);

            foreach (var c in topCustomers)
                Console.WriteLine($"{c.CustomerId} | {c.OrdersCount}");

            // 8. Топ 10 поръчки по оборот
            Console.WriteLine("\n8. Топ 10 поръчки по оборот:");
            var topOrders = context.OrderDetails
                .GroupBy(od => od.OrderId)
                .Select(g => new
                {
                    OrderId = g.Key,
                    Total = g.Sum(od => od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount))
                })
                .OrderByDescending(x => x.Total)
                .Take(10);

            foreach (var o in topOrders)
                Console.WriteLine($"{o.OrderId} | {o.Total:F2}");

            // 9. Клиенти с повече от 10 поръчки
            Console.WriteLine("\n9. Клиенти с повече от 10 поръчки:");
            var activeCustomers = context.Orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, OrdersCount = g.Count() })
                .Where(x => x.OrdersCount > 10)
                .OrderByDescending(x => x.OrdersCount);

            foreach (var c in activeCustomers)
                Console.WriteLine($"{c.CustomerId} | {c.OrdersCount}");

            // 10. Топ 5 продукти по продадена бройка
            Console.WriteLine("\n10. Топ 5 продукти по продадена бройка:");
            var topProducts = context.OrderDetails
                .GroupBy(od => od.Product)
                .Select(g => new
                {
                    ProductName = g.Key.ProductName,
                    TotalQuantity = g.Sum(od => od.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(5);

            foreach (var p in topProducts)
                Console.WriteLine($"{p.ProductName} | {p.TotalQuantity}");
        }
    }

}
