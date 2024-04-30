using EFCoreInMemory.Data;
using EFCoreInMemory.Models;
using EFCoreInMemory.Models.RequestModel;
using EFCoreInMemory.Models.ChangeModels;
using EFCoreInMemory.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFCoreInMemory.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> CreateCustomer(CreateCustomerRequestModel requestModel)
        {
            try
            {
                await _appDbContext.Customers.AddAsync(requestModel.Change());
                int result = await _appDbContext.SaveChangesAsync();

                return result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<CustomerDataModel>> GetCustomers()
        {
            try
            {
                return await _appDbContext.Customers
                    .AsNoTracking()
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}