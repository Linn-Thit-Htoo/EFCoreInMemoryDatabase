using EFCoreInMemory.Data;
using EFCoreInMemory.Models.Entities;

namespace EFCoreInMemory.Extenstions;

public static class AddCustomerService
{
    public async static Task AddCustomer(this WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var _appDbContext = scope.ServiceProvider.GetService<AppDbContext>()!;

        var customer1 = new CustomerDataModel()
        {
            CustomerId = Guid.NewGuid().ToString(),
            CustomerName = "Leo",
            Email = "leo@gmail.com",
            Age = 18
        };

        var customer2 = new CustomerDataModel()
        {
            CustomerId = Guid.NewGuid().ToString(),
            CustomerName = "Linn Thit",
            Email = "linnthit77387@gmail.com",
            Age = 19
        };

        await _appDbContext.Customers.AddAsync(customer1);
        await _appDbContext.Customers.AddAsync(customer2);
        await _appDbContext.SaveChangesAsync();
    }
}