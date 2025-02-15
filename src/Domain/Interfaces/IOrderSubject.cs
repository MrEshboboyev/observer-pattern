using Domain.Interfaces;
using Domain.Models;

namespace Domain.Interfaces;

public interface IOrderSubject
{
    void Attach(IOrderObserver observer);
    void Detach(IOrderObserver observer);
    void Notify(Order order);
}
