using FinalProject.Application.DTOs.Identity;
using FinalProject.Application.Interfaces.Repositories.Identity;
using FinalProject.Domain.Entities.Identity;

namespace FinalProject.Infrastructure.Services
{
    public class RoleService : CoreService<Role, RoleViewDTO, RoleAddDTO, RoleUpdateDTO, BaseDeletedDTO>, IRoleService
    {
        public RoleService(IRoleRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}