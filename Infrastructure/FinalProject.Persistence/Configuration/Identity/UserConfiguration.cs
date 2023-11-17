
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Persistence.Configuration.Identity
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("Users");

            builder.HasMany(b=>b.UserRoles).WithOne(p=>p.User).HasForeignKey(b=>b.UserId);
        }
    }
}
