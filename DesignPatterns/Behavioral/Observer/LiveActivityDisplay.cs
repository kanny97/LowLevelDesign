using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class LiveActivityDisplay : IFitnessDataObserver
    {
        public void Update(FitnessData fitnessData)
        {
            Console.WriteLine($"Live Activity Display Updated: Steps={fitnessData.GetSteps()}, Distance={fitnessData.GetDistance()} km, Calories Burned={fitnessData.GetCaloriesBurned()}");
        }
    }
}
