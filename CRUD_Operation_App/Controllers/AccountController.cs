using CRUD.DAL.Models;
using CRUD_Operation_App.Helpers;
using CRUD_Operation_App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUD_Operation_App.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
			_userManager = userManager;
			_signInManager = signInManager;
		}
        #region Sign Up
        public IActionResult SignUp()
        {
            return View();  
        }
		// Account/SignUp
		[HttpPost]
		public async Task<IActionResult> SignUp(SignUpViewModel model) 
		{
            if(ModelState.IsValid) //Server Side Validation
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if(user is null)
                {
					user = new ApplicationUser()
					{
						UserName = model.UserName,
						Email = model.Email,
						IsAgree = model.IsAgree,
						FName = model.FName,
						LName = model.LName,
					};
					var  result =await _userManager.CreateAsync(user, model.Password);
					
					if(result.Succeeded)
					{
						return RedirectToAction(nameof(SignIn));
					}


                    foreach (var error in result.Errors)
                    {
						ModelState.AddModelError(string.Empty, error.Description);
                    }
                }

				ModelState.AddModelError(string.Empty, "Username is already exists :");
                
            }
			return View(model);
		}

		#endregion

		#region Sign In
		public IActionResult SignIn()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignIn(SignInViewModel model)
		{
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
				if(user is not null)
				{
					var flag = await _userManager.CheckPasswordAsync(user, model.Password);
					if(flag) 
					{
						var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe , false); 
						if(result.Succeeded)
						{
							return RedirectToAction(nameof(HomeController.Index) , "Home");	
						}
					}
				}
				ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model);
		}
		#endregion

		#region Sign Out
		public async new Task<IActionResult> SignOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction(nameof(SignIn));
		}


		#endregion

		#region Forget Password
		public IActionResult ForgetPassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SendResetPasswordUrl(ForgetPasswordViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);
				if(user is not null)
				{
					var token =await _userManager.GeneratePasswordResetTokenAsync(user); //Unique For This User For One-Time 
					var resetPasswordUrl = Url.Action("ResetPassword", "Account", new {email = model.Email , token = token },Request.Scheme);

					var email = new Email()
					{
						Subject = "Reset You Password",
						Recipients = model.Email,
						Body = resetPasswordUrl
                    };
					EmailSettings.SendEmail(email);
					return RedirectToAction(nameof(CheckYourInbox));
				}
				ModelState.AddModelError(string.Empty, "Invalid Email");

			}
			return View(model);
		}
		
		public IActionResult CheckYourInbox()
		{
			return View();
		}
		#endregion
	}
}
