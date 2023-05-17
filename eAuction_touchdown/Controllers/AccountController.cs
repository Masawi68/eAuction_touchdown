﻿using eAuction_touchdown.Models;
using eAuction_touchdown.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eAuction_touchdown.Controllers
{
	public class AccountController : Controller
	{
		private readonly IAccountRepository _accountRepository;

		public AccountController(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}

		[Route("signup")]
		public IActionResult Signup()
		{
			return View();
		}

		[Route("signup")]
		[HttpPost]
		public async Task<IActionResult> Signup(SignUpUserModel userModel)
		{
			if (ModelState.IsValid)
			{
				// write your code
				var result = await _accountRepository.CreateUserAsync(userModel);
				if (!result.Succeeded)
				{
					foreach (var errorMessage in result.Errors)
					{
						ModelState.AddModelError("", errorMessage.Description);
					}

					return View(userModel);
				}
				ModelState.Clear();
				
			}
			return View(userModel);
		}	
	}
}