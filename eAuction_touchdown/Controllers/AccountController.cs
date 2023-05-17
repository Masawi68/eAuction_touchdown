using eAuction_touchdown.Models;
using Microsoft.AspNetCore.Mvc;

namespace eAuction_touchdown.Controllers
{
    public class AccountController : Controller
    {
        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }

		[Route("signup")]
        [HttpPost]
		public IActionResult Signup(SignUpUserModel userModel)
		{
            if (ModelState.IsValid) 
            {
                // write your code
                ModelState.Clear();
            }

			return View();
		}
	}
}