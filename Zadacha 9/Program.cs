using Magic_Numbers.Controller;
using Magic_Numbers.Models;

namespace Magic_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int magicNumber = int.Parse(Console.ReadLine());

            var input = new MagicNumberInput(magicNumber);
            var service = new MagicNumberService();
            var result = service.Generate(input);

            Console.WriteLine(string.Join(" ", result.MagicCombinations));
        }
    }
}