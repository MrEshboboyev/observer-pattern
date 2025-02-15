namespace Domain.Models;

public class Order(int orderId, string product, decimal amount, string customerEmail)
{
    public int OrderId { get; } = orderId;
    public string Product { get; } = product;
    public decimal Amount { get; } = amount;
    public string CustomerEmail { get; } = customerEmail;
}
