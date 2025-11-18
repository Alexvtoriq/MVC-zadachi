using Vegetable_market.Models;
using Vegetable_market.Controller;

namespace Vegetable_market
{
    public class Program
    {
        public static void Main()
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());

            var input = new MarketInput(vegPrice, fruitPrice, vegKg, fruitKg);
            var service = new MarketService();
            var result = service.CalculateRevenue(input);

            Console.WriteLine($"{result.TotalEuro} euro");
        }
    }
}