using EFCoreInMemory.Models.Entities;
using EFCoreInMemory.Models.RequestModel;

namespace EFCoreInMemory.Repositories;

public interface ICustomerRepository
{
    Task<List<CustomerDataModel>> GetCustomers();
    Task<int> CreateCustomer(CreateCustomerRequestModel requestModel);
}