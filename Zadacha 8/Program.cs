using Division_Without_Remainder.Controller;
using Division_Without_Remainder.Models;

namespace Division_Without_Remainder
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            var input = new DivisionInput(numbers);
            var service = new DivisionService();
            var result = service.Calculate(input);

            Console.WriteLine($"{result.P1:F2}%");
            Console.WriteLine($"{result.P2:F2}%");
            Console.WriteLine($"{result.P3:F2}%");
        }
    }
}