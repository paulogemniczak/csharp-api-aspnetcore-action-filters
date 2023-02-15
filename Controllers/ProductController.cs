using csharp_api_aspnetcore_action_filters.ActionFilters;
using csharp_api_aspnetcore_action_filters.Entities;
using Microsoft.AspNetCore.Mvc;

namespace csharp_api_aspnetcore_action_filters.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpPost]
		[ServiceFilter(typeof(ValidationFilterAttribute))]
		public IActionResult Post([FromBody] Product model)
		{
			// _appService.Create(model);
			return Ok();
		}
	}
}
