

namespace FinalProject.Persistence.Configuration
{
    public class TeacherConfiguration : BaseEntityConfiguration<Teacher>
    {
        public override void Configure(EntityTypeBuilder<Teacher> builder)
        {
            base.Configure(builder);

            builder.ToTable("Teachers");
        }
    }
}
