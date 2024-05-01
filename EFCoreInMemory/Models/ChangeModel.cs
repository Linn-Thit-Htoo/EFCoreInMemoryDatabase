using EFCoreInMemory.Models.Entities;
using EFCoreInMemory.Models.RequestModel;

namespace EFCoreInMemory.Models;

public static class ChangeModel
{
    public static CustomerDataModel Change(this CreateCustomerRequestModel requestModel)
    {
        var model = new CustomerDataModel()
        {
            CustomerId = Guid.NewGuid().ToString(),
            CustomerName = requestModel.CustomerName,
            Email = requestModel.Email,
            Age = requestModel.Age
        };

        return model;
    }
}