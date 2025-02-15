using Application.Subjects;
using Domain.Models;

namespace Application.Observers;

public class OrderService
{
    private readonly OrderManager _orderManager;

    public OrderService()
    {
        _orderManager = new OrderManager();

        // Register observers
        _orderManager.Attach(new InventoryService());
        _orderManager.Attach(new ShippingService());
        _orderManager.Attach(new NotificationService());
    }

    public void PlaceOrder(Order order)
    {
        _orderManager.PlaceOrder(order);
    }
}
