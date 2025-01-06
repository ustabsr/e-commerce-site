using System.Security.Claims;
using FoodApplication.Models;

namespace FoodApplication.Repository
{
	public interface IData
	{
		Task<ApplicationUser> GetUser(ClaimsPrincipal claims);
	}
}
