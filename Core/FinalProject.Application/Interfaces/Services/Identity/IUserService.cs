using FinalProject.Application.DTOs.Identity;

namespace FinalProject.Application.Interfaces.Services
{
    public interface IUserService : ICoreService<User, UserViewDTO, UserAddDTO, UserUpdateDTO, BaseDeletedDTO>
    {
    }
}
