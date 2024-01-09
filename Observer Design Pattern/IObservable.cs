using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    internal interface IObservable
    {
        
        public void Attatch(IObserver observer);
        public void Detecth(IObserver observer);
        public void notify();
        
    }
}
