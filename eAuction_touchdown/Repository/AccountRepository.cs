using eAuction_touchdown.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace eAuction_touchdown.Repository
{
	public class AccountRepository : IAccountRepository
	{
		private readonly UserManager<IdentityUser> _userManager;

		public AccountRepository(UserManager<IdentityUser> userManager)
		
		{
			_userManager = userManager;
		}	
		public async Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
		{
			var user = new IdentityUser()
			{
				Email = userModel.Email,
				UserName = userModel.Email
			};
			var result = await _userManager.CreateAsync(user, userModel.Password);
			return result;
		}
	}
}
 