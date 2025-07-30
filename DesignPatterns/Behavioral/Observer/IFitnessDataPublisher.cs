using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IFitnessDataPublisher
    {
        void RegisterObserver(IFitnessDataObserver observer);
        void UnregisterObserver(IFitnessDataObserver observer);
        void NotifyObservers();
    }
}
