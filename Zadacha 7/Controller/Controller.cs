using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Models;

namespace Travel.Controller
{
    public class TravelService
    {
        public TravelResult PlanTrip(TravelInput input)
        {
            string destination = "";
            string vacationType = "";
            double price = 0;

            if (input.Budget <= 100)
            {
                destination = "Bulgaria";
                if (input.Season == "summer")
                {
                    vacationType = "Camp";
                    price = input.Budget * 0.30;
                }
                else
                {
                    vacationType = "Hotel";
                    price = input.Budget * 0.70;
                }
            }
            else if (input.Budget <= 1000)
            {
                destination = "Balkans";
                if (input.Season == "summer")
                {
                    vacationType = "Camp";
                    price = input.Budget * 0.40;
                }
                else
                {
                    vacationType = "Hotel";
                    price = input.Budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                vacationType = "Hotel";
                price = input.Budget * 0.90;
            }

            return new TravelResult(destination, vacationType, price);
        }
    }

}