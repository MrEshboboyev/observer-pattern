using Domain.Interfaces;
using Domain.Models;

namespace Application.Observers;

public class ShippingService : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"🚚 Shipping Order {order.OrderId}: " +
            $"Preparing shipment for {order.Product}.");
    }
}
