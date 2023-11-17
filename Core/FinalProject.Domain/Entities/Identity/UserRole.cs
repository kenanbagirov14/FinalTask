using FinalProject.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities.Identity
{
    public class UserRole : Entity
    {
        public int UserId { get; set; }
        public User User { get; set; } 
        public int RoleId { get; set; }
        public Role Role { get; set; }

        

    }
}
