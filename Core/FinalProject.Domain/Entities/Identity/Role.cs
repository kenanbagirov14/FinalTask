using FinalProject.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities.Identity
{
    public class Role : Entity
    {
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

    }
}
