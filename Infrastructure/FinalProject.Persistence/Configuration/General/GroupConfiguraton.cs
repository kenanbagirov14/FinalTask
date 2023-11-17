

namespace FinalProject.Persistence.Configuration
{
    public class GroupConfiguraton : BaseEntityConfiguration<Group>
    {
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);

            builder.ToTable("Groups");
            builder.Property(p => p.GroupName).HasMaxLength(50);
           
            builder.HasOne(p=>p.Teacher).WithMany(p=>p.Groups).HasForeignKey(p=>p.TeacherId);
        }
    }
}
