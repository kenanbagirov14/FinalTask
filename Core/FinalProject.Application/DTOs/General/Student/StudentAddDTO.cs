using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.DTOs.General
{
    public class StudentAddDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int GroupId { get; set; }
        public string? ImagaPath { get; set; }
        public string? ImagaFullPath { get; set; }
        public IFormFile? File { get; set; }
    }
}
