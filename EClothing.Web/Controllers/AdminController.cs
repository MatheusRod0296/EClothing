using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EClothing.Web.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
         [Authorize(Roles = "Costumer")]
        public IActionResult Secure()
        {
            
            var x = User;
            var context = HttpContext;
            var accessToken =  HttpContext.GetTokenAsync("access_token").Result;
            var xxx  = new JwtSecurityTokenHandler().ReadToken(accessToken);
           
           
            return View();
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("oidc");
        }
    }

}