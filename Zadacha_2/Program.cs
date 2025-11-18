using ConsoleApp6.Controller;
using ConsoleApp6.Model;
using ConsoleApp6.View;

namespace ConsoleApp6;

public class Program
{
    public static void Main()
    {
        ExamArrivalModel model = new ExamArrivalModel();
        ExamArrivalView view = new ExamArrivalView();
        ExamArrivalController controller = new ExamArrivalController(model, view);

        controller.Run();
    }
}


