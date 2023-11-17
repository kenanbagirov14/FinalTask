
namespace FinalProject.Application.DTOs.General
{
    public class StudentViewDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string GroupName { get; set; }
        public string? ImagaPath { get; set; }
    }
}
