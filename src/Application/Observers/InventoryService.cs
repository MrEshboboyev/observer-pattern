using System;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Observers;

public class InventoryService : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"📦 Inventory Updated: {order.Product} stock reduced.");
    }
}
