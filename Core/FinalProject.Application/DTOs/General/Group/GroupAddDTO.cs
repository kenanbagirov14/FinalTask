using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.DTOs.General
{
    public class GroupAddDTO : BaseDTO
    {
        public string GroupName { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public int TeacherId { get; set; }

    }
}
