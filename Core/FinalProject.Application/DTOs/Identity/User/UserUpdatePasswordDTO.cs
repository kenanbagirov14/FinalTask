using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.DTOs.Identity
{
    public class UserUpdatePasswordDTO : BaseDTO
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
        public string UserName{ get; set; }
        public string Email { get; set; }
    }
}
