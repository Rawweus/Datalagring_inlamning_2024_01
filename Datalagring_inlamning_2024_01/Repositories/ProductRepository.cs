using Datalagring_inlamning_2024_01.Contexts;
using Datalagring_inlamning_2024_01.Entities;

namespace Datalagring_inlamning_2024_01.Repositories;

public class ProductRepository(DataContext context)
{
    private readonly DataContext _context = context;

    public IEnumerable<ProductEntity> GetAll()
    {
        return _context.Products.ToList();
    }

    public void Add(ProductEntity entity)
    {
        _context.Products.Add(entity);
        _context.SaveChanges();
    }

    public ProductEntity Get(int id)
    {
        return _context.Products.SingleOrDefault(c => c.ProductId == id);
    }

    public void Update(ProductEntity entity)
    {
        _context.Products.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(ProductEntity entity)
    {
        _context.Products.Remove(entity);
        _context.SaveChanges();
    }
}