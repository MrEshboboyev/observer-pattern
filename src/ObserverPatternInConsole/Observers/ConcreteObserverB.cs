using ObserverPatternInConsole.Subjects;

namespace ObserverPatternInConsole.Observers;

// Concrete Observers react to the updates issued by the Subject they had been
// attached to.
public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject)?.State == 0 || (subject as Subject)?.State > 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}
