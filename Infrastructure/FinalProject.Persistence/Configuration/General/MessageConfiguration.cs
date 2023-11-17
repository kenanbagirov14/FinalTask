using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Persistence.Configuration.General
{
    public class MessageConfiguration : BaseEntityConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            base.Configure(builder);
            builder.ToTable("Messages");
            builder.Property(p=>p.Text).HasMaxLength(1000);
            builder.Property(p=>p.Name).HasMaxLength(100);
            builder.Property(p=>p.Email).HasMaxLength(100);
            builder.Property(p=>p.IsView).ValueGeneratedOnAdd().HasDefaultValue(false);
            
        }
    }
}
