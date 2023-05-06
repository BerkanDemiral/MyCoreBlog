using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyCoreBlog.Entites.DTOs.Users;
using MyCoreBlog.Entites.Entities;

namespace MyCoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        /// <summary>
        /// Login ekranını ilk açarken karşımıza get yapısı çıkacak. ÖR: Giren kullanıcının bilgilerini getireceğiz ekranda bir yerlere vs... 
        /// Başta db'yi yoracak bir işlem yapılmayacak sadece get ile 1-2 veri çekilecek o yüzden TASK kullanmadık. ama POST kısmında TASK kullanacağız
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "E posta adresiniz veya şifreniz yanlıştır");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E posta adresiniz veya şifreniz yanlıştır");
                    return View();
                }
            }

            else
            {
                return View();

            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
	
}
