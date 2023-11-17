using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure.Repositories.General
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
        }
    }
}