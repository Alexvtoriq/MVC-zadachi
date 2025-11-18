
    using System;

    namespace TransportCalculator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                
                int n = int.Parse(Console.ReadLine());
                string period = Console.ReadLine(); 

              
                var service = new TransportService();

                var request = new TravelRequestModel
                {
                    Kilometers = n,
                    Period = period
                };

                var result = service.GetCheapestOption(request);

             
                Console.WriteLine($"{result.CheapestPrice:F2}");
            }
        }
    }


