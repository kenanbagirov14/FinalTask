using FinalProject.Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.DTOs.General
{
    public class GroupViewDTO : BaseDTO
    {
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }

    }
}
