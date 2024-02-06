using System.ComponentModel.DataAnnotations;

namespace Datalagring_inlamning_2024_01.Entities;

public class CustomerEntity
{
    public CustomerEntity()
    {
        Orders = new HashSet<OrderEntity>();
    }
    
    public int CustomerId { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;

    public virtual ICollection<OrderEntity> Orders { get; set; }
}
