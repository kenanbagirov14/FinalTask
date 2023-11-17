using FinalProject.Application.DTOs.General;

namespace FinalProject.Application.Interfaces.Services
{
    public interface ITeacherService : ICoreService<Teacher, TeacherViewDTO, TeacherAddDTO, TeacherUpdateDTO, BaseDeletedDTO>
    {
    }
}
