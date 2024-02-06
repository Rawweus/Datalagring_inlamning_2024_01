using Datalagring_inlamning_2024_01.Entities;
using Datalagring_inlamning_2024_01.Repositories;

namespace Datalagring_inlamning_2024_01.Services;

public class ProductService(ProductRepository productRepository)
{
    private readonly ProductRepository _productRepository = productRepository;

    public void AddProduct(ProductEntity product)
    {
        _productRepository.Add(product);
    }
}
