namespace Datalagring_inlamning_2024_01.Entities;

public class ProductEntity
{
    public ProductEntity()
    {
        OrderDetails = new HashSet<OrderDetailEntity>();
    }

    public int ProductId { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    public virtual CategoryEntity Category { get; set; } = null!;

    public virtual ICollection<OrderDetailEntity> OrderDetails { get; set; }


}
