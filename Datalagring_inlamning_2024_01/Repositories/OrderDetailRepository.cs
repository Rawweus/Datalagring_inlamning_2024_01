using Datalagring_inlamning_2024_01.Contexts;
using Datalagring_inlamning_2024_01.Entities;

namespace Datalagring_inlamning_2024_01.Repositories;

public class OrderDetailRepository(DataContext context)
{
    private readonly DataContext _context = context;

    public IEnumerable<OrderDetailEntity> GetAll()
    {
        return _context.OrderDetails.ToList();
    }

    public void Add(OrderDetailEntity entity)
    {
        _context.OrderDetails.Add(entity);
        _context.SaveChanges();
    }

    public OrderDetailEntity Get(int id)
    {
        return _context.OrderDetails.FirstOrDefault(c => c.OrderDetailId == id);
    }

    public void Update(OrderDetailEntity entity)
    {
        _context.OrderDetails.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(OrderDetailEntity entity)
    {
        _context.OrderDetails.Remove(entity);
        _context.SaveChanges();
    }
}