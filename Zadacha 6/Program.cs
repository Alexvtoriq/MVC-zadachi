using Pipes_In_A_Pool.Models;
using Pipes_In_A_Pool.Controller;

namespace Pipes_In_A_Pool
{
    public class Program
    {
        public static void Main()
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine();

            var input = new PoolInput(V, P1, P2, H);
            var service = new PoolService();
            var result = service.Calculate(input);

            Console.WriteLine(result.OutputMessage);
        }
    }
}