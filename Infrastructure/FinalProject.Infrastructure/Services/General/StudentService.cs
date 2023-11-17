using FinalProject.Application.DTOs.General;

namespace FinalProject.Infrastructure.Services
{
    public class StudentService : CoreService<Student, StudentViewDTO, StudentAddDTO, StudentUpdateDTO, BaseDeletedDTO>, IStudentService
    {
        public StudentService(IStudentRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override async Task<ICollection<StudentViewDTO>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync("Group");
            var response = data.Select(s => new StudentViewDTO { Id = s.Id, GroupName = s.Group.GroupName, Name = s.Name, BirthDate = s.BirthDate, Surname = s.Surname,ImagaPath=s.ImagaPath }).ToList();
            return response;

        }
    }
}