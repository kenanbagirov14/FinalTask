using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.DTOs.General
{
    public class TeacherViewDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ImagaPath { get; set; }
        public string? FrontImagaPath { get; set; }
        public string? Description { get; set; }
    }
}
