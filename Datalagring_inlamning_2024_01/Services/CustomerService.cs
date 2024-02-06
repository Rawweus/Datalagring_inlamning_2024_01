using Datalagring_inlamning_2024_01.Entities;
using Datalagring_inlamning_2024_01.Repositories;

namespace Datalagring_inlamning_2024_01.Services;

public class CustomerService(CustomerRepository customerRepository)
{
    private readonly CustomerRepository _customerRepository = customerRepository;

    public void AddCustomer(CustomerEntity customer)
    {
        _customerRepository.Add(customer);
    }
}
