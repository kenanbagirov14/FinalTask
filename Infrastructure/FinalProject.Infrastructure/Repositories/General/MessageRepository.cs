using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure.Repositories.General
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
        }
    }
}
