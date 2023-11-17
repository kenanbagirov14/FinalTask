

namespace FinalProject.Persistence.Configuration.General
{
    public class SettingConfiguration : BaseEntityConfiguration<Setting>
    {
        public override void Configure(EntityTypeBuilder<Setting> builder)
        {
            base.Configure(builder);
            builder.ToTable("Settings");
        }
    }
}
