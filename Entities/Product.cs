using csharp_action_filters.Contracts;
using System.ComponentModel.DataAnnotations;

namespace csharp_action_filters.Entities
{
	public class Product : IEntity
	{
		[Key]
		public int ProductId { get; set; }

		[Required(ErrorMessage = "Product code is required")]
		public int ProductCode { get; set; }

		[Required(ErrorMessage = "Product name is required")]
		public string? ProductName { get; set; } = null;
	}
}
