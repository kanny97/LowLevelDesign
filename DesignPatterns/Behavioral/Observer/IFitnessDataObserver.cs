using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IFitnessDataObserver
    {
        public void Update(FitnessData fitnessData);
    }
}
