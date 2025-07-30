using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class FitnessData : IFitnessDataPublisher
    {
        private readonly List<IFitnessDataObserver> observers = new List<IFitnessDataObserver>();
        private int steps;
        private double distance;
        private double caloriesBurned;
        public void RegisterObserver(IFitnessDataObserver observer)
        {
            observers.Add(observer);
        }
        public void UnregisterObserver(IFitnessDataObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
        public void SetFitnessData(int steps, double distance, double caloriesBurned)
        {
            this.steps = steps;
            this.distance = distance;
            this.caloriesBurned = caloriesBurned;
            Console.WriteLine($"Fitness Data Updated: Steps={steps}, Distance={distance} km, Calories Burned={caloriesBurned}");
            NotifyObservers();
        }
        public void DailyReset()
        {
            steps = 0;
            distance = 0.0;
            caloriesBurned = 0.0;
            Console.WriteLine("Fitness Data Reset to Zero.");
            NotifyObservers();
        }
        public int GetSteps()
        {
            return steps;
        }
        public double GetDistance()
        {
            return distance;
        }
        public double GetCaloriesBurned()
        {
            return caloriesBurned;
        }
    }
}
