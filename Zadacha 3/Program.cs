namespace Zadacha_3
{
    public class HistogramRequestModel
    {
        public List<int> Numbers { get; set; } = new List<int>();
    }

    public class HistogramResultModel
    {
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
    }

    public class HistogramView
    {
        public HistogramRequestModel GetUserInput()
        {
            var request = new HistogramRequestModel();
            Console.WriteLine("Enter numbers separated by space:");
            var input = Console.ReadLine();
            request.Numbers = input.Split(' ').Select(int.Parse).ToList();
            return request;
        }

        public void ShowResult(HistogramResultModel result)
        {
            Console.WriteLine($"p1 (<200): {result.P1:F2}%");
            Console.WriteLine($"p2 (200-399): {result.P2:F2}%");
            Console.WriteLine($"p3 (400-599): {result.P3:F2}%");
            Console.WriteLine($"p4 (600-799): {result.P4:F2}%");
            Console.WriteLine($"p5 (800+): {result.P5:F2}%");
        }
    }

    public class HistogramController
    {
        private readonly HistogramView _view;

        public HistogramController()
        {
            _view = new HistogramView();
        }

        public void Run()
        {
            var request = _view.GetUserInput();
            var result = CalculateHistogramPercentages(request);
            _view.ShowResult(result);
        }

        private HistogramResultModel CalculateHistogramPercentages(HistogramRequestModel request)
        {
            int total = request.Numbers.Count;
            int p1 = request.Numbers.Count(x => x < 200);
            int p2 = request.Numbers.Count(x => x >= 200 && x <= 399);
            int p3 = request.Numbers.Count(x => x >= 400 && x <= 599);
            int p4 = request.Numbers.Count(x => x >= 600 && x <= 799);
            int p5 = request.Numbers.Count(x => x >= 800);

            return new HistogramResultModel
            {
                P1 = p1 * 100.0 / total,
                P2 = p2 * 100.0 / total,
                P3 = p3 * 100.0 / total,
                P4 = p4 * 100.0 / total,
                P5 = p5 * 100.0 / total
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var controller = new HistogramController();
            controller.Run();
        }
    }
}
