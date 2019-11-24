using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Repositories.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("bigint")
                .IsRequired();

            builder
                .Property(a => a.RefreshToken)
                .HasColumnType("nvarchar")
                .HasColumnName("RefreshToken")
                .HasMaxLength(50);

            builder
               .Property(a => a.CarNumber)
               .HasColumnType("nvarchar(max)")
               .HasColumnName("CarNumber")
               .HasMaxLength(50);

            builder
                .Property(a => a.FirstName)
                .HasColumnType("nvarchar")
                .HasColumnName("FirstName")
                .HasMaxLength(50);

            builder
                .Property(a => a.LastName)
                .HasColumnType("nvarchar")
                .HasColumnName("LastName")
                .HasMaxLength(50);

            builder
                .Property(a => a.Email)
                .HasColumnType("nvarchar")
                .HasColumnName("Email")
                .HasMaxLength(50);

            builder
                .Property(a => a.IsBlocked)
                .HasColumnType("bit")
                .HasColumnName("IsBlocked");

            builder
                .Property(a => a.CarNumber)
                .HasColumnType("nvarchar")
                .HasColumnName("CarNumber")
                .HasMaxLength(50);
        }
    }
}