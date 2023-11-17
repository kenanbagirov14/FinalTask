using FinalProject.Application.DTOs.Identity;
using FinalProject.Application.DTOs.Identity.User;
using System.Text;

namespace FinalProject.Web.Areas.Admin.ServiceFacades
{
    public class LoginServiceFacade
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoginServiceFacade(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> Login(Login user)
        {
            var findUser = await _userService.FindUserByLoginAsync(user);
            if (findUser == null)
            {
                return false;
            }
            else
            {

                _httpContextAccessor.HttpContext?.Session.SetString("UserId", findUser.Id.ToString());
                _httpContextAccessor.HttpContext?.Session.SetString("Username", findUser.UserName);

                return true;
            }
        }

        public async Task<Tuple<bool,string>> Registr(UserAddDTO user)
        {
            var sb = new StringBuilder();
            var registrResult = await _userService.AddAsync(user);
            switch (registrResult)
            {
                case 0: sb.AppendLine("User model is null"); break;
                case 2: sb.AppendLine("Username is exist") ; break;
                case 3: sb.AppendLine("Password confirmation is incorrect") ; break;
            }
            if (registrResult!=1)
            {
                return Tuple.Create(false, sb.ToString());
            }
            else
            {
                return Tuple.Create(true,"");
            }
        }
    }
}
