using System;

namespace TransportCalculator
{
    public class TravelRequestModel
    {
        public int Kilometres { get; set; }
        public string Period { get; set; } 
    }

    public class TravelResultModel
    {
        public double CheapestPrice { get; set; }
        public string TransportType { get; set; } 
    }

    public class TravelView
    {
        public TravelRequestModel GetUserInput()
        {
            TravelRequestModel request = new TravelRequestModel();
            Console.WriteLine("Enter the distance in kilometres:");
            request.Kilometres = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the period (day/night):");
            request.Period = Console.ReadLine().ToLower();
            return request;
        }

        public void ShowResult(TravelResultModel result)
        {
            Console.WriteLine($"The cheapest price is {result.CheapestPrice:F2} using {result.TransportType}.");
        }
    }
    public class TravelController
    {
        private readonly TravelView _view;
        public TravelController(TravelView view)
        {
            _view = view;
        }
        public void ProcessTravelRequest()
        {
            var request = _view.GetUserInput();
            var result = CalculateCheapestTransport(request);
            _view.ShowResult(result);
        }
        private TravelResultModel CalculateCheapestTransport(TravelRequestModel request)
        {
            double taxiRatePerKm = request.Period == "day" ? 0.79 : 0.90;
            double busRatePerKm = 0.09;
            double trainRatePerKm = 0.06;
            double taxiCost = 0.70 + (taxiRatePerKm * request.Kilometres);
            double busCost = request.Kilometres >= 20 ? busRatePerKm * request.Kilometres : double.MaxValue;
            double trainCost = request.Kilometres >= 100 ? trainRatePerKm * request.Kilometres : double.MaxValue;
            double cheapestPrice = Math.Min(taxiCost, Math.Min(busCost, trainCost));
            string transportType = cheapestPrice == taxiCost ? "Taxi" :
                                   cheapestPrice == busCost ? "Bus" : "Train";
            return new TravelResultModel
            {
                CheapestPrice = cheapestPrice,
                TransportType = transportType
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TravelView view = new TravelView();
            TravelController controller = new TravelController(view);
            controller.ProcessTravelRequest();
        }
    }

}


