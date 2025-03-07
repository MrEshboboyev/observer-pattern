// The client code
using ObserverPatternInConsole.Observers;
using ObserverPatternInConsole.Subjects;

var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Detach(observerA);

subject.SomeBusinessLogic();