using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocietyCare.AuthenticateData;
using SocietyCare.Contracts;

namespace SocietyCare.Controllers
{
    [Authorize]
    [Route("api/UserAccountAction")]
    public class UserAccountActionController : Controller
    {
        // GET api/values
        #region Declaration
        UserDetails _userDetails;
        private ApplicationUser applicationUser;
        #endregion
        public UserAccountActionController()
        {
             applicationUser = new ApplicationUser(Startup.connString);
        }
       
        [HttpGet]
        [Route("Login")]
        public string LoginAccount()
        {
            _userDetails = new UserDetails();
           
         
            return "";
        }
        [HttpPost]
        [Route("Registeration")]
        public bool RegisterAccount(UserDetails userData)
        {
            bool isRegister = false;
            return isRegister;
        }
        [HttpPost]
        [Route("Deactivate")]
        public bool DeactivateAccount(string userId)
        {
            bool isDeactive = false;
            return isDeactive;
        }
        [HttpPost]
        [Route("ForgotPassword")]
        public bool ResetPassword(string userId)
        {
            bool isValidate = false;
            return isValidate;
        }
        [HttpPost]
        [Route("GetSubscription")]
        public bool EnrollSubscription(string userId, int subscriptionCode)
        {
            bool isValidate = false;
            return isValidate;
        }
        [HttpPost]
        [Route("ActivateAccount")]
        public bool MakeAccountActive(string userId,string password)
        {
            bool isActive = false;
            return isActive;
        }
    }
}
