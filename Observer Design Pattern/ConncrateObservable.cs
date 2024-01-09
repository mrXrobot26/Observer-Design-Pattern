namespace Observer_Design_Pattern
{
    internal class ConncrateObservable : IObservable
    {
        public List<IObserver> Observers = new List<IObserver>();
        public void Attatch(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detecth(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
