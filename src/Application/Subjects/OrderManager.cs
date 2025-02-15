using Domain.Interfaces;
using Domain.Models;

namespace Application.Subjects;

public class OrderManager : IOrderSubject
{
    private readonly List<IOrderObserver> _observers = [];

    public void Attach(IOrderObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IOrderObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(Order order)
    {
        Console.WriteLine("\n📢 Notifying all services about the new order...");
        foreach (var observer in _observers)
        {
            observer.Update(order);
        }
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"🛒 Order {order.OrderId} placed for {order.Product} (${order.Amount})");
        Notify(order);
    }
}
