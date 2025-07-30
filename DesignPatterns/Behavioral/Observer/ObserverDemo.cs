using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverDemo
    {
        public static void Main(String[] args)
        {
            FitnessData fitnessData = new FitnessData();
            GoalNotifier goalNotifier = new GoalNotifier();
            LiveActivityDisplay liveActivityDisplay = new LiveActivityDisplay();
            ProgressLogger progressLogger = new ProgressLogger();

            fitnessData.RegisterObserver(goalNotifier);
            fitnessData.RegisterObserver(liveActivityDisplay);
            fitnessData.RegisterObserver(progressLogger);

            fitnessData.SetFitnessData(5000, 4.0, 300);
            fitnessData.SetFitnessData(10000, 8.0, 600);
            fitnessData.SetFitnessData(15000, 12.0, 900);

            goalNotifier.ResetGoal();
            fitnessData.DailyReset();
        }
    }
}
