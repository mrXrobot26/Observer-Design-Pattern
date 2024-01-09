namespace Observer_Design_Pattern
{
    internal class ConcerateObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("notified sussesfuly");
        }
    }
}
