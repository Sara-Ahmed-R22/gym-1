using gym_1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym_1.Context.Configuration
{
    public class MemberConfiguration : GymUserConfiguration<member>, IEntityTypeConfiguration<member>
    {
        public void Configure(EntityTypeBuilder<member> builder)
        {
            builder.Property(x => x.CreatedAt).HasColumnName("JoinDate")
    .HasDefaultValueSql("getdate()");
            base.Configure(builder);
           
        }
    }
}
