using FinalProject.Application.DTOs.General;

namespace FinalProject.Infrastructure.Services
{
    public class TeacherService : CoreService<Teacher, TeacherViewDTO, TeacherAddDTO, TeacherUpdateDTO, BaseDeletedDTO>, ITeacherService
    {
        public TeacherService(ITeacherRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}