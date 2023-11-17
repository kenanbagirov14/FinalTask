using FinalProject.Application.DTOs.General;

namespace FinalProject.Application.Interfaces.Services
{
    public interface IStudentService : ICoreService<Student, StudentViewDTO, StudentAddDTO, StudentUpdateDTO, BaseDeletedDTO>
    {
    }
}
