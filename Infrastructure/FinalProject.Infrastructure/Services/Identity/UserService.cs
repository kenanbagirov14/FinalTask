using FinalProject.Application.DTOs.Identity;
using FinalProject.Application.Interfaces.Repositories.Identity;
using FinalProject.Domain.Entities.Identity;

namespace FinalProject.Infrastructure.Services
{
    public class UserService : CoreService<User,UserViewDTO,UserAddDTO,UserUpdateDTO, BaseDeletedDTO>, IUserService
    {
        public UserService(IUserRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}