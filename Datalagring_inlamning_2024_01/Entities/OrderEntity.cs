namespace Datalagring_inlamning_2024_01.Entities;

public class OrderEntity
{
    public OrderEntity()
    {
        OrderDetails = new HashSet<OrderDetailEntity>();
    }

    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }

    public virtual CustomerEntity Customer { get; set; } = null!;

    public virtual ICollection<OrderDetailEntity> OrderDetails { get; set; }
}
