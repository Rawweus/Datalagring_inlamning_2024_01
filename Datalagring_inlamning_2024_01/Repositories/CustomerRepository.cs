using Datalagring_inlamning_2024_01.Contexts;
using Datalagring_inlamning_2024_01.Entities;

namespace Datalagring_inlamning_2024_01.Repositories;

public class CustomerRepository(DataContext context)
{
    private readonly DataContext _context = context;

    public IEnumerable<CustomerEntity> GetAll()
    {
        return _context.Customers.ToList();
    }

    public void Add(CustomerEntity entity)
    {
        _context.Customers.Add(entity);
        _context.SaveChanges();
    }

    public CustomerEntity Get(int id)
    {
        return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
    }

    public void Update(CustomerEntity entity)
    {
        _context.Customers.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(CustomerEntity entity)
    {
        _context.Customers.Remove(entity);
        _context.SaveChanges();
    }
}