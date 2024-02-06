namespace Datalagring_inlamning_2024_01.Entities;

public class OrderDetailEntity
{
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public virtual OrderEntity Order { get; set; } = null!;
    public virtual ProductEntity Product { get; set; } = null!;
}
