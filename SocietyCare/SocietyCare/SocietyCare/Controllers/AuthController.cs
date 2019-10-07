using Microsoft.AspNetCore.Mvc;
using SocietyCare.AuthenticateData;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace SocietyCare.Controllers
{
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        private readonly ApplicationUser _userManager;
        public AuthController()
        {
            _userManager = new ApplicationUser(Startup.connString);
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(string userName,string password)
        {
            var user =_userManager.GetByEmailAndPassword(userName, password);
            if (user != null)
            {
                return Ok(new
                {
                    token = Utilities.GenerateTokens(userName)
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("RefreshToken")]
        public dynamic RefreshToken()
        {
            var authorization = HttpContext.Request.Headers["Authorization"].SingleOrDefault();
            var token = authorization.Substring(authorization.IndexOf(' ') + 1);
            var jwt = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;

            dynamic result = new
            {
                code = 106,
                data = new
                {
                    user = new
                    {
                        email = jwt.Subject,
                    },
                    token = Utilities.GenerateTokens(jwt.Subject),
                }
            };

            return result;
        }

    }
}