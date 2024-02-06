using Datalagring_inlamning_2024_01.Contexts;
using Datalagring_inlamning_2024_01.Entities;

namespace Datalagring_inlamning_2024_01.Repositories;

public class CategoryRepository(DataContext context)
{
    private readonly DataContext _context = context;

    public IEnumerable<CategoryEntity> GetAll()
    {
        return _context.Categories.ToList();
    }

    public void Add(CategoryEntity entity)
    {
        _context.Categories.Add(entity);
        _context.SaveChanges();
    }

    public CategoryEntity Get(int id)
    {
        return _context.Categories.FirstOrDefault(c => c.CategoryId == id);
    }

    public void Update(CategoryEntity entity)
    {
        _context.Categories.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(CategoryEntity entity)
    {
        _context.Categories.Remove(entity);
        _context.SaveChanges();
    }
}

