using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models.ApiRequest;
using OnlineShop.Models.Options;
using OnlineShop.Services;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AccountService m_accountService;

        public AccountController(AccountService accountService)
        {
            m_accountService = accountService;
        }
        [HttpPost("[action]")]
        public TokenData Login(Login login)
        {
            return m_accountService.Token(login.NickName, login.Password);
        }

        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return Ok();
        //}
    }
}
