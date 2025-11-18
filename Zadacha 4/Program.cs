using Dumb_Password_Generator.Models;
using Dumb_Password_Generator.Controller;

namespace Dumb_Password_Generator
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var input = new PasswordGeneratorInput(n, l);
            var service = new PasswordGeneratorService();
            var output = service.Generate(input);

            Console.WriteLine(string.Join(" ", output.Passwords));
        }
    }

}