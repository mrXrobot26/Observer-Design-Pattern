namespace Observer_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConncrateObservable conncrateObservableA = new ConncrateObservable();
            ConcerateObserver observerA = new ConcerateObserver();
            ConcerateObserver observerB = new ConcerateObserver();

            conncrateObservableA.Attatch(observerA);
            conncrateObservableA.Attatch(observerB);
            conncrateObservableA.notify();
            conncrateObservableA.Detecth(observerB);

            Console.WriteLine("===============================================");

            conncrateObservableA.notify();
        }
    }
}
