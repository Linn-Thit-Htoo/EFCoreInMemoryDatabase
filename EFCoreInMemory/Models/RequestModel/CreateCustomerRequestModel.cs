using System;
namespace EFCoreInMemory.Models.RequestModel
{
	public class CreateCustomerRequestModel
    {
        public string CustomerName { get; set; } = null!;
        public string Email { get; set; } = null!; // the value will not be null despite its initial assignment
        public int Age { get; set; }
    }
}