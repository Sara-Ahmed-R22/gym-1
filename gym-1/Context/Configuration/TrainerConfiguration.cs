using gym_1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym_1.Context.Configuration
{
    public class TrainerConfiguration : GymUserConfiguration<trainer>, IEntityTypeConfiguration<trainer>
    {
        public void Configure(EntityTypeBuilder<trainer> builder)
        {
            builder.Property(x => x.CreatedAt).HasColumnName("HireDate")
    .HasDefaultValueSql("getdate()");
            base.Configure(builder);

        }
    }
}
