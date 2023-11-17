using FinalProject.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities.General
{
    public class Group : Entity
    {
        public string GroupName { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set;}
        public ICollection<Student> Students { get; set; }
    }
}
