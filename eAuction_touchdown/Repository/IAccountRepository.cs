using eAuction_touchdown.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace eAuction_touchdown.Repository
{
	public interface IAccountRepository
	{
		Task <IdentityResult>CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

    }
}