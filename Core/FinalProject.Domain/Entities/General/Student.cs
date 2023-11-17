using FinalProject.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities.General
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ImagaPath { get; set; }
        public string? ImagaFullPath { get; set; }
        public int GroupId {  get; set; }   
        public Group Group { get; set; } 
    }
}
