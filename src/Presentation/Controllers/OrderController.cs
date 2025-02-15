using Microsoft.AspNetCore.Mvc;
using Application.Observers;
using Domain.Models;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController()
    {
        _orderService = new OrderService();
    }

    [HttpPost("place")]
    public IActionResult PlaceOrder(int orderId, string product, decimal amount, string email)
    {
        var order = new Order(orderId, product, amount, email);
        _orderService.PlaceOrder(order);
        return Ok("Order placed successfully.");
    }
}
