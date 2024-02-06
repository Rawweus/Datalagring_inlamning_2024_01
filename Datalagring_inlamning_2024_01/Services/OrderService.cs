using Datalagring_inlamning_2024_01.Entities;
using Datalagring_inlamning_2024_01.Repositories;

namespace Datalagring_inlamning_2024_01.Services;

public class OrderService(OrderRepository orderRepository)
{
    private readonly OrderRepository _orderRepository = orderRepository;

    public void AddOrderDetail(OrderEntity order)
    {
        _orderRepository.Add(order);
    }
}
