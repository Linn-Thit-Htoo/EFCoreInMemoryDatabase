using EFCoreInMemory.Models.RequestModel;

namespace EFCoreInMemory.Models.ChangeModels
{
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
}