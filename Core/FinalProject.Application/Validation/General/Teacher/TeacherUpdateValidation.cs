using FluentValidation;

namespace FinalProject.Application.Validation.General.Teacher
{
    public class TeacherUpdateValidation : AbstractValidator<TeacherUpdateDTO>
    {
        public TeacherUpdateValidation()
        {
            RuleFor(r => r.Name).NotNull().NotEmpty();
            RuleFor(r => r.Surname).NotNull().NotEmpty();
            RuleFor(r => r.Experience).NotNull().NotEmpty();
        }
    }
}
