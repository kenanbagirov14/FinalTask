using FinalProject.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities.General
{
    public class Message : Entity
    {
        public string Email {  get; set; }  
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsView { get; set; }
    }
}
