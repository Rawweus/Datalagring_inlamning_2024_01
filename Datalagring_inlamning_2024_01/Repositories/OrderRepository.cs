using Datalagring_inlamning_2024_01.Contexts;
using Datalagring_inlamning_2024_01.Entities;

namespace Datalagring_inlamning_2024_01.Repositories;

public class OrderRepository(DataContext context)
{
    private readonly DataContext _context = context;

    public IEnumerable<OrderEntity> GetAll()
    {
        return _context.Orders.ToList();
    }

    public void Add(OrderEntity entity)
    {
        _context.Orders.Add(entity);
        _context.SaveChanges();
    }

    public OrderEntity Get(int id)
    {
        return _context.Orders.FirstOrDefault(c => c.OrderId == id);
    }

    public void Update(OrderEntity entity)
    {
        _context.Orders.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(OrderEntity entity)
    {
        _context.Orders.Remove(entity);
        _context.SaveChanges();
    }

    internal void Add(OrderDetailEntity order)
    {
        throw new NotImplementedException();
    }
}