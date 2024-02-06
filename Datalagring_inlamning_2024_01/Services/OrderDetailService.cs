using Datalagring_inlamning_2024_01.Entities;
using Datalagring_inlamning_2024_01.Repositories;

namespace Datalagring_inlamning_2024_01.Services;

public class OrderDetailService(OrderDetailRepository orderDetailRepository)
{
    private readonly OrderDetailRepository _orderDetailRepository = orderDetailRepository;

    public void AddOrderDetail(OrderDetailEntity orderDetail)
    {
        _orderDetailRepository.Add(orderDetail);
    }
}
