public class GeneratorModel
{
    public int Number { get; set; } 
    public string Text { get; set; }
}
public class GeneratorView
{
    public int GetNumberOfPasswords()
    {
        Console.WriteLine("Enter how many passwords to generate:");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Please enter a valid positive number:");
        }
        return number;
    }

    public void ShowPasswords(List<GeneratorModel> passwords)
    {
        Console.WriteLine("Generated passwords:");
        foreach (var password in passwords)
        {
            Console.WriteLine($"#{password.Number}: {password.Text}");
        }
    }
}
public class GeneratorController
{
    private readonly GeneratorView _view;

    public GeneratorController()
    {
        _view = new GeneratorView();
    }

    public void Run()
    {
        int n = _view.GetNumberOfPasswords();

        var passwords = GeneratePasswords(n);

        _view.ShowPasswords(passwords);
    }

    private List<GeneratorModel> GeneratePasswords(int n)
    {
        var list = new List<GeneratorModel>();
        for (int i = 1; i <= n; i++)
        {
            string password = $"P{i:D3}"; 
            list.Add(new GeneratorModel { Number = i, Text = password });
        }
        return list;
    }
}
class Program
{
    static void Main(string[] args)
    {
        var controller = new GeneratorController();
        controller.Run();
    }
}