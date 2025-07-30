using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public interface IParkingLotPublisher
    {
        void AddObserver(IParkingLotObserver observer);
        void RemoveObserver(IParkingLotObserver observer);
        void NotifyObservers(string message);
    }
}
