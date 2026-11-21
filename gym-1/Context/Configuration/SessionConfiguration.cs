using gym_1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym_1.Context.Configuration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
            builder.HasOne(x => x.trainer).WithMany(x => x.sessions)
                .HasForeignKey(x=> x.trainerId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T => {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity BETWEEN 1 AND 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate > StartDate");

            } ); 
        }
    }
}
