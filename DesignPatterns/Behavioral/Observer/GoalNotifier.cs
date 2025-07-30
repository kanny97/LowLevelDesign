using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class GoalNotifier : IFitnessDataObserver
    {
        private const int dailyStepGoal = 10000;
        private bool isGoalReached;
        public void Update(FitnessData fitnessData)
        {
            if (fitnessData.GetSteps() >= dailyStepGoal && !isGoalReached)
            {
                isGoalReached = true;
                Console.WriteLine("Congratulations! You've reached your daily step goal!");
            }
        }
        public void ResetGoal()
        {
            isGoalReached = false;
            Console.WriteLine("Daily step goal has been reset.");
        }
    }
}
