using Domain.Models;

namespace Domain.Interfaces;

public interface IOrderObserver
{
    void Update(Order order);
}
