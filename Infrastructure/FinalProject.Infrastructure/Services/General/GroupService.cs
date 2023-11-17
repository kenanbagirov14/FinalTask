using FinalProject.Application.DTOs.General;

namespace FinalProject.Infrastructure.Services
{
    public class GroupService : CoreService<Group, GroupViewDTO, GroupAddDTO, GroupUpdateDTO, BaseDeletedDTO>, IGroupService
    {
        public GroupService(IGroupRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override async Task<ICollection<GroupViewDTO>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync("Teacher");
            var response = data.Select(s => new GroupViewDTO { Id = s.Id, GroupName = s.GroupName, MaxAge = s.MaxAge, MinAge = s.MinAge, TeacherName = s.Teacher.Name }).ToList();
            return response;

        }
    }
}
