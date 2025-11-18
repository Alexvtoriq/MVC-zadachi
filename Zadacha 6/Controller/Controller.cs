using Pipes_In_A_Pool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_In_A_Pool.Controller
{
    public class PoolService
    {
        public PoolResult Calculate(PoolInput input)
        {
            double totalPipe1 = input.Pipe1Flow * input.Hours;
            double totalPipe2 = input.Pipe2Flow * input.Hours;

            double totalWater = totalPipe1 + totalPipe2;

            if (totalWater <= input.Volume)
            {
                
                double percentFull = Math.Floor(totalWater * 100 / input.Volume);
                double percentP1 = Math.Floor(totalPipe1 * 100 / totalWater);
                double percentP2 = Math.Floor(totalPipe2 * 100 / totalWater);

                string text = $"The pool is {percentFull}% full. " +
                              $"Pipe 1: {percentP1}%. Pipe 2: {percentP2}%.";

                return new PoolResult(text);
            }
            else
            {
             
                double overflow = totalWater - input.Volume;

                string text = $"For {input.Hours} hours the pool overflows with {overflow} liters.";

                return new PoolResult(text);
            }
        }
    }
}