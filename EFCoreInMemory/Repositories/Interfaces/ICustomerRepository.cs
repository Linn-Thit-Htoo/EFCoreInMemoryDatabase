using System;
using EFCoreInMemory.Models;
using EFCoreInMemory.Models.RequestModel;

namespace EFCoreInMemory.Repositories.Interfaces
{
	public interface ICustomerRepository
	{
		Task<List<CustomerDataModel>> GetCustomers();
		Task<int> CreateCustomer(CreateCustomerRequestModel requestModel);
	}
}