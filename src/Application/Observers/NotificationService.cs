using Domain.Interfaces;
using Domain.Models;

namespace Application.Observers;

public class NotificationService : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"📧 Email sent to {order.CustomerEmail}:" +
            $" Order {order.OrderId} placed successfully.");
    }
}
