using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Persistence.Configuration.Identity
{
    public class  RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.ToTable("Roles");

            builder.HasMany(b => b.UserRoles).WithOne(p => p.Role).HasForeignKey(b => b.RoleId);
        }
    }
}
