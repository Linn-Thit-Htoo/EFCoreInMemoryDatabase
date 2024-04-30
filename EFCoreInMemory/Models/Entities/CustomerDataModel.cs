using System.ComponentModel.DataAnnotations;

namespace EFCoreInMemory.Models
{
    public class CustomerDataModel
	{
		[Key]
		public string CustomerId { get; set; } = null!;
		public string CustomerName { get; set; } = null!;
		public string Email { get; set; } = null!; // the value will not be null despite its initial assignment
        public int Age { get; set; }
    }
}