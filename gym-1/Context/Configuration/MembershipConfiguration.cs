using gym_1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym_1.Context.Configuration
{
    public class MembershipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
        }
    }
}
