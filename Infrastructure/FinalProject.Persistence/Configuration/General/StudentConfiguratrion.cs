
namespace FinalProject.Persistence.Configuration
{
    public class StudentConfiguratrion:BaseEntityConfiguration<Student>
    {
        public override void Configure(EntityTypeBuilder<Student> builder)
        {
            base.Configure(builder);
            builder.ToTable("Students");

            builder.HasOne(p => p.Group).WithMany(p => p.Students).HasForeignKey(p => p.GroupId);
        }
    }
}
