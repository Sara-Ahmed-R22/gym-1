using gym_1.Entities;
using Microsoft.EntityFrameworkCore;

namespace gym_1.Context.Configuration
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.ComplexProperty(x => x.Address);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "Email Like '%@%.com' ");
                T.HasCheckConstraint("GymUser_PhoneCheck", "LEN(phone) =11 And( Phone Like '010%' or Phone Like '012%' or Phone Like '011%' or Phone Like '015%')");

            });

        }
    }
}
