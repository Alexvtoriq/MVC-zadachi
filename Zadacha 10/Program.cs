using Tile_Repair.Controller;
using Tile_Repair.Models;

namespace Tile_Repair
{
    public class Program
    {
        public static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            var input = new TileRepairInput(n, w, l, m, o);
            var service = new TileRepairService();
            var result = service.Calculate(input);

            Console.WriteLine(result.TilesNeeded);
            Console.WriteLine(result.TimeNeeded);
        }
    }
}