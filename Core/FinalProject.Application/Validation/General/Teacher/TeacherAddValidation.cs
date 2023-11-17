using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Validation.General.Teacher
{
    public class TeacherAddValidation : AbstractValidator<TeacherAddDTO>
    {
        public TeacherAddValidation()
        {
            RuleFor(r=>r.Name).NotNull().NotEmpty();
            RuleFor(r=>r.Surname).NotNull().NotEmpty();
            RuleFor(r=>r.Experience).NotNull().NotEmpty();
        }
    }
}
