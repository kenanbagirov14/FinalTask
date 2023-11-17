using FinalProject.Application.DTOs.Identity;
using FinalProject.Application.DTOs.Identity.User;

namespace FinalProject.Application.Interfaces.Services
{
    public interface IUserService : ICoreService<User, UserViewDTO, UserAddDTO, UserUpdateDTO, BaseDeletedDTO>
    {
        UserViewDTO AuthenticateUser(Login user);

         Task<UserViewDTO> FindUserByLoginAsync(Login user);

        bool CheckUserName(string UserName);

    }

   
}
