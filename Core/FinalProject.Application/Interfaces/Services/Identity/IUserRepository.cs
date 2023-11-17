using FinalProject.Application.DTOs.Identity;

namespace FinalProject.Application.Interfaces.Services
{
    public interface IRoleService : ICoreService<Role, RoleViewDTO, RoleAddDTO, RoleUpdateDTO, BaseDeletedDTO>
    {
    }
}
