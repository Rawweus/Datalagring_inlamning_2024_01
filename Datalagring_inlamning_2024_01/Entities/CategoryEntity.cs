namespace Datalagring_inlamning_2024_01.Entities;

public class CategoryEntity
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = null!;

    public virtual ICollection<ProductEntity>? Products { get; set; }
}
